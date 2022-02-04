using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace ScoringSystemWinFormsUI
{
    public partial class ScoringProgram : Form
    {
        #region Constructor

        public ScoringProgram()
        {
            InitializeComponent();

            // Set window's min & max size
            MinimumSize = new Size(555, 435);
            MaximumSize = new Size(555, 435);
        }

        #endregion

        #region Fields

        // Creating the eventScores and totalScores dictionaries 
        public IDictionary<string, int[]> EventScores = new Dictionary<string, int[]>();
        public IDictionary<string, int> TotalScores = new Dictionary<string, int>();

        // Tells us if each contestant is in an event or not, used to disable input and update the UI
        public Dictionary<string, bool[]> IsInEvents = new Dictionary<string, bool[]>();

        // Arrays to store number of contestants per event
        // And how many spaces are left in each event
        private int[] NumEntrants = new int[5];
        private int[] NumSpaces = new int[5];

        #endregion

        #region Helper Methods

        /// <summary>
        /// Clears all of the data in the eventScores and totalScores dictionaries by assigning them new, empty dicts
        /// </summary>
        /// <param name="eventScores">The dictionary containing the event scores</param>
        /// <param name="totalScores">The dictionary containing the total scores</param>
        
        public void ResetProgram()
        {
            // Overwrites data in dicts by assigning them empty dicts
            EventScores = new Dictionary<string, int[]>();
            TotalScores = new Dictionary<string, int>();
            IsInEvents = new Dictionary<string, bool[]>();

            // Reset numParticipants 
            // And numSpacesLeft array
            NumEntrants = new int[5];
            NumSpaces = new int[5];

            // Selects view by rank by default
            eventViewComboBox.SelectedIndex = 1;

            // For each of the pages in our tabcontrol
            foreach (TabPage tp in tabControl.TabPages)
            {
                // Enabled is true if the tabControl's name is "setUpEventsPage" else it's false/disabled
                ((Control)tp).Enabled = tp.Name == "setUpEventsPage";
            }

            // Disable uneeded buttons before set up has finshed
            writeToFileButton.Enabled = false;
            clearDataButton.Enabled = false;

            // Create an array of all of our event name text boxes to loop over           
            TextBox[] eventNameTextboxes =
            {
                event1NameTextBox,
                event2NameTextBox,
                event3NameTextBox,
                event4NameTextBox,
                event5NameTextBox
            };

            // Create an array of all of our num. contestant numericUpDowns to loop over
            NumericUpDown[] numContestantTextBoxes =
            {
                event1NumContestants,
                event2NumContestants,
                event3NumContestants,
                event4NumContestants,
                event5NumContestants
            };

            // Array of all our checkboxes for the events
            CheckBox[] eventCheckBoxes =
            {
                checkBoxEvent1,
                checkBoxEvent2,
                checkBoxEvent3,
                checkBoxEvent4,
                checkBoxEvent5
            };
        
            // Loop 5 times 
            for (int i = 0; i < 5; i++)
            {
                // Reset event name inputs
                // Reset num contestants inputs
                // Reset the event check boxes
                eventNameTextboxes[i].Text = "";
                numContestantTextBoxes[i].Value = 10;
                eventCheckBoxes[i].Checked = false;
            }

            // Clear list box, name text box and single event check box
            spacesLeftListBox.Items.Clear();
            nameInputTextBox.Text = "";
            singleEventCheckbox.Checked = false;
        }

        /// <summary>
        /// Clears all of the data in a DataGridView and refreshes it.
        /// </summary>

        public void ClearDGV(DataGridView dataGridViewToClear)
        {
            // If the DataGridView isn't empty
            if (dataGridViewToClear.Rows.Count > 0)
            {
                // Clear all rows
                // Then refresh
                dataGridViewToClear.Rows.Clear();
                dataGridViewToClear.Refresh();
            }
        }
        
        /// <summary>
        /// Sorts an array of a dictionary's values in ascending order, then matches the values to the correct keys.
        /// </summary>
        /// <param name="unsortedDictionary">The unsorted dictionary to sort</param>
        /// <returns>A copy of the unsorted dictionary, after being sorted by value</returns>

        private IDictionary<string, int> SortLowToHigh(IDictionary<string, int> unsortedDictionary)
        {
            // Takes a list and performs an insertion sort
            // Returns a copy of the list, but sorted
            List<int> InsertionSortList(List<int> unsortedList)
            {
                // Create two sublists, first one is a list of all of the item's we've sorted so far
                // Start by adding the first item in the unsorted list, so we can do value comparisons
                // Then remove the first item from the unsorted list, since we want to move it
                List<int> sortedSublist = new List<int>(unsortedList[0]);
                unsortedList.Remove(0);

                // Now we've moved the first item over, we can store all the unsorted item in an unsorted sublist
                List<int> unsortedSublist = unsortedList;

                // Each time this loop runs it's a 'pass' of the insertion sort algorithm
                // We pass through the list again if the unsorted sublist has no items in it, which means the list is sorted
                while (unsortedSublist.Count > 0)
                {
                    // For each item in the unsorted sublist
                    // ***NOTE*** It kept throwing an argument out of range exception when iterating forwards,
                    // but when iterating backwards it works fine. hmmmmmmmmm
                    for (int j = unsortedSublist.Count - 1 ; j > - 1; j--)
                    {
                        // Flagging variable that tells us if the unsorted item is smaller than all of the sorted items
                        // If it is, we'll insert the unsorted item at the start of the sorted list
                        bool unsortedItemIsSmallerThanAllSortedItems = true;

                        // Compare it to each item in the sorted sublist                      
                        // We're looping backwards because the sorted sublist is in ascending order, but we want to 
                        // go through it in descending order to get the largest, then 2nd largest, then 3rd etc.
                        for (int i = sortedSublist.Count - 1; i > - 1; i--)
                        {
                            // If it's larger, insert it into the list after that item
                            // The break out of the loop because we don't need to compare it to any other items
                            // If not, go to the next largest item
                            if (unsortedSublist[j] > sortedSublist[i])
                            {
                                sortedSublist.Insert(i + 1, unsortedSublist[j]);
                                unsortedItemIsSmallerThanAllSortedItems = false;
                                break;
                            }
                        }

                        // If the unsorted item is smaller than all sorted items
                        // Insert it at the start of the sorted list, since it's the smallest
                        if (unsortedItemIsSmallerThanAllSortedItems)
                        {
                            sortedSublist.Insert(0, unsortedSublist[j]);
                        }

                        // Now we've moved the item in the unsorted list to the correct place in the sorted list,
                        // we can remove it from the unsorted list
                        unsortedSublist.RemoveAt(j);
                    }
                }

                // When done, return the sorted sublist, which is now simply the sorted version of the list 
                return sortedSublist;
            }
            
            // We need a list of sorted values, to compare to all of the keys in the unsorted dict
            // We do this by running the insertion sort method on the unsorted dictionary values, converted to a list
            // Then we get a list of the unsorted dictionary's keys, which we use for comparisons
            List<int> sortedDictionaryValues = InsertionSortList(unsortedDictionary.Values.ToList());
            List<string> unsortedDictionaryKeys = unsortedDictionary.Keys.ToList();

            // The we create an empty dictionay. We'll add each sorted value, after finding the key that matches it
            IDictionary<string, int> sortedDictionary = new Dictionary<string, int>();

            // Loop through each item in the list of sorted dictionary values
            for (int v = 0; v < sortedDictionaryValues.Count; v++)
            {
                // For each item in the sorted values list, compare it to the list of keys in the unsorted dictionary
                for (int k = 0; k < unsortedDictionaryKeys.Count; k++)
                {
                    // Once the key that matches the value is found
                    // Add the key and the value to the empty dictionary we created
                    // By looping over the sorted dictionary values first, we get a dictionary sorted by values
                    if (unsortedDictionary[unsortedDictionaryKeys[k]] == sortedDictionaryValues[v])
                    {
                        sortedDictionary[unsortedDictionaryKeys[k]] = sortedDictionaryValues[v];
                    }
                }
            }

            // Return the sorted dictionary
            return sortedDictionary;           
        }

        /// <summary>
        /// Sorts an array of a dictionary's values, then matches the values to the correct keys, then reverses it.
        /// </summary>
        /// <param name="unsortedDictionary">The unsorted dictionary to sort</param>
        /// <returns>A copy of the unsorted dictionary, after being sorted by value</returns>

        private IDictionary<string, int> SortHighToLow(IDictionary<string, int> unsortedDictionary)
        {
            // Sorts the dictionary by value, in ascending order
            // Then puts it in a new dictionary
            // Them, create an empty dictiary which we'll use to add values to 
            IDictionary<string, int> sortedDictionaryAscending = SortLowToHigh(unsortedDictionary);
            IDictionary<string, int> sortedDictionaryDescending = new Dictionary<string, int>();

            // Start with the last item in the dictionary sorted by ascending order of value
            // Loop backwards through each item until we reach the first
            for (int i = sortedDictionaryAscending.Count - 1; i > - 1;  i--)
            {
                // Place the item at the start of the new dictionary
                sortedDictionaryDescending.Add(sortedDictionaryAscending.ElementAt(i));
            }

            // Then return the dictionary sorted by descending order
            return sortedDictionaryDescending;
        }

        /// <summary>
        /// Copies the data in the total scores dictionary to the total scores output table.
        /// </summary>

        private void OutputTotalScores()
        {
            // Clear table before writing data from totalScores to outputTable
            // Doing this because it prevents duplicated from being added
            ClearDGV(totalScoresOutputTable);

            // ***NOTE*** This only works if totalScores and the outputTable are in the same row

            // Loop over each row of the output table
            for (int i = 0; i < TotalScores.Count; i++)
            {
                // Get key and value from totalScores to use for comparisons
                string currentKey = TotalScores.ElementAt(i).Key;
                string currentValue = TotalScores.ElementAt(i).Value.ToString();

                // Create a new array that contains the name and total score of a competitor
                // Add the row to the DataGridView representing the output table
                string[] newRow = new string[2] { currentKey.ToString(), currentValue.ToString() };
                totalScoresOutputTable.Rows.Add(newRow);               
            }
        }

        /// <summary>
        /// Copies the data in the event scores dictionary to the event scores output table.
        /// </summary>

        private void OutputEventScores()
        {
            // Clear the DGV to prevent duplicates
            ClearDGV(eventResultsTable);

            // Loop through each entry in the eventScores dictionary
            // This goes through all of the contestants
            foreach (KeyValuePair<string, int[]> entry in EventScores)
            {
                // Get the contestant name
                // Then get their scores in each event, stored in an array
                string currentKey = entry.Key;
                int[] currentValues = entry.Value;

                // Create new array for the row to add the the event output table
                // Set the first element to the name (tKey) as the name is the first column
                string[] newRow = new string[6];
                newRow[0] = currentKey;

                // Go through the contestant's score in each event
                for (int i = 0; i < currentValues.Length; i++)
                {
                    // If their score for that event is 0, they didn't take part 
                    // Because the minimum score is 1
                    if (currentValues[i] == 0)
                    {
                        // So instead show 'N/A'
                        // Then go straight to the next contestant and don't run the code below
                        newRow[i + 1] = "N/A";
                        continue;
                    }

                    // Example: The second row (index 1) gets the first score in tValues (index 0)
                    newRow[i + 1] = currentValues[i].ToString();
                }

                // Then, finally, we add the row to the table
                eventResultsTable.Rows.Add(newRow);
            }
        }
        
        /// <summary>
        /// This code runs if the user switches the view on the event output tab to view by rank.
        /// </summary>

        private void ShowEventRanksIO()
        {
            // Clear the DGV to prevent duplicates
            ClearDGV(eventResultsTable);

            // Loop through each entry in the eventScores dictionary
            // This goes through all of the contestants
            foreach (KeyValuePair<string, int[]> entry in EventScores)
            {
                // Get the contestant name
                // Then get their scores in each event, stored in an array
                string currentKey = entry.Key;
                int[] currentValues = entry.Value;

                // Create new array for the row to add the the event output table
                // Set the first element to the name (tKey) as the name is the first column
                string[] newRow = new string[6];
                newRow[0] = currentKey;

                // Go through the contestant's score in each event
                for (int i = 0; i < currentValues.Length; i++)
                {
                    // If the score is 0, they haven't placed in the competition
                    // Because they'd have a score of 1 which is the lowest 
                    if (currentValues[i] == 0)
                    {
                        // Therefore, we show 'N/A' in the DGV
                        // Then go to the next contestant and skip the code below
                        newRow[i + 1] = "N/A";
                        continue;
                    }

                    // Example: The second row (index 1) gets the first score in tValues (index 0)
                    // Since we're converting the scores to ranks, we use 11 - score 
                    // This is because score = 11 - rank, so score + rank = 11, meaning rank = 11 - score
                    newRow[i + 1] = (NumEntrants[i] + 1 - currentValues[i]).ToString();
                }

                // Then, finally, we add the row to the table
                eventResultsTable.Rows.Add(newRow);
            }
        }

        /// <summary>
        /// Loops through each item in eventScores and sums them, then updates the totalScores dictionary.
        /// </summary>

        private void UpdateTotalScores()
        {
            // Loop through each entry in the eventScores dictionary
            foreach (KeyValuePair<string, int[]> entry in EventScores)
            {
                string tKey = entry.Key; // Temporary variable to store name
                int tValue = 0; // Temporary variable to store total score

                // Loop over each of the current competitor's scores
                // This loop sums all of the event scores into a total
                for (int i = 0; i < entry.Value.Length; i++)
                {
                    // Add the score for that event to the total
                    tValue += entry.Value[i];
                }

                // If the key is already in the totalScores dictionary
                if (TotalScores.ContainsKey(tKey))
                {
                    // Update the value 
                    TotalScores[tKey] = tValue;
                }

                else // If the key isn't already in totalScores
                {
                    // Add the temporary key and value to total scores
                    TotalScores.Add(new KeyValuePair<string, int>(tKey, tValue));
                }
            }
        }

        /// <summary>
        /// Determines if a name is valid or not.
        /// </summary>
        /// <param name="nameInput"></param>
        /// <returns></returns>

        private bool NameIsValid(string nameInput)
        {
            // If name is left blank 
            if (string.IsNullOrWhiteSpace(nameInput))
            {
                // Show an error message saying that the name cannot be blank
                MessageBox.Show("The name cannot be left empty.", "Invalid Input");
                return false;
            }

            // Use regex to check if the name isn't made up of alphabetical characters only
            else if (!Regex.IsMatch(nameInput, @"^[a-zA-Z]+$"))
            {
                // Show an error message saying that the name cannot contain any non-alphabetical characters
                MessageBox.Show("The name cannot contain any non-alphabetical characters.", "Invalid Input");
                return false;
            }

            // If string is valid, return true
            return true;
        }

        /// <summary>
        /// Determines if a rank is valid or not.
        /// </summary>
        /// <param name="rankInput"></param>
        /// <returns></returns>

        private bool RankIsValid(string rankInput, int eventIdx)
        {
            int rank;
            bool isNumber = int.TryParse(rankInput, out rank);

            char[] operators = { '+', '-', '*', '/', '%' };

            for (int i = 0; i < rankInput.Length; i++)
            {
                for (int j = 0; j < operators.Length; j++)
                {
                    if (rankInput[i] == operators[j])
                    {
                        MessageBox.Show("The rank cannot contain an expression. Please enter a number", "Invalid Input");
                        return false;
                    }
                }
            }

            // If input is empty or whitespace
            if (string.IsNullOrWhiteSpace(rankInput))
            {
                // Display error message and return false
                MessageBox.Show("The rank cannot be left empty.", "Invalid Input");
                return false;            
            }

            // If int.TryParse returns false, a.k.a the string couldn't be converted to a number
            else if (!isNumber)
            {
                // Display error message and return false
                MessageBox.Show($"{rankInput} is not a valid input for the rank.", "Invalid Input");
                return false;
            }           

            // If the rank is above 10
            else if (rank > NumEntrants[eventIdx])
            {
                // Display error message and return false
                MessageBox.Show($"The rank cannot be above {NumEntrants[eventIdx]}.\n" +
                    $"This event has a maximum of {NumEntrants[eventIdx]} contestants.", "Invalid Input");
                return false;
            }

            // If the rank is below 1
            else if (rank < 1)
            {
                // Display error message and return false
                MessageBox.Show("The rank cannot be below 1.", "Invalid Input");
                return false;
            }

            // If no errors are found, return true
            return true;
        }

        /// <summary>
        /// This checks to see if the name of an event is valid
        /// </summary>
        /// <param name="nameInput"></param>
        /// <returns></returns>

        private bool EventNameIsValid(string nameInput, int eventIdx)
        {
            // If name is left blank 
            if (string.IsNullOrWhiteSpace(nameInput))
            {
                // Show an error message saying that the name cannot be blank
                MessageBox.Show($"The name of Event {eventIdx + 1} cannot be left empty.", "Invalid Input");
                return false;
            }

            // Use regex to check if the name isn't made up of alphabetical characters only
            else if (!Regex.IsMatch(nameInput, @"^[a-zA-Z]+$"))
            {
                // Show an error message saying that the name cannot contain any non-alphabetical characters
                MessageBox.Show($"The name of Event {eventIdx + 1} cannot contain any non-alphabetical characters.", "Invalid Input");
                return false;
            }

            // If string is valid, return true
            return true;
        }

        /// <summary>
        /// Disables input in the event results table and updates the UI based on whether a contestant is in an event.
        /// </summary>

        private void RestrictRankInputs()
        {
            // Go through all of the rows in the events table
            for (int i = 0; i < eventResultsTable.RowCount; i++)
            {
                // Get the name of the contestant from the first cell in the row
                // Then we want to get the participatory statuses of the contestant in each event
                string name = eventResultsTable.Rows[i].Cells[0].Value.ToString();
                bool[] isInEvent = IsInEvents[name];
             
                // Then, for each of the events 
                for (int j = 0; j < 5; j++)
                {
                    // Get the cell that corresponds to the name and event in our array
                    DataGridViewCell currentCell = eventResultsTable.Rows[i].Cells[j + 1];

                    // Change the colour to grey if the user isn't in the event. Else turn it to white if they are in the event
                    // Then we want to make it so that the user can't enter any data for the contestant's rank if not in the event
                    currentCell.Style.BackColor = new Color[2] { Color.Gray, Color.White }[Convert.ToInt32(isInEvent[j])];

                    if (!isInEvent[j])
                        currentCell.ReadOnly = true;
                }

                eventResultsTable.Rows[i].Cells[0].ReadOnly = true;
            }

            // Then disallow user to change name
            eventResultsTable.Columns[0].ReadOnly = true;
        }

        #endregion

        #region Event Methods

        /// <summary>
        /// If a user changes tab, this code runs. It checks which tab is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Once the selected tab is changed, check if it's the total scores output tab
            if (tabControl.SelectedTab == tabControl.TabPages["totalsOutputTab"])
            {          
                // Then copy the data from the dictionary to the output table
                OutputTotalScores();
            }

            // Once the selected tab is changed, check if it's the event scores output tab
            else if (tabControl.SelectedTab == tabControl.TabPages["eventViewTab"])
            {
                // Copy scores from dictionary to DGV
                OutputEventScores();

                // Disable inputs for all the cells where a contestant isn't in an event
                RestrictRankInputs();
            }
        }

        /// <summary>
        /// This code is run if the user clicks the enter button on the input tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void enterInputButton_Click(object sender, EventArgs e)
        {
            // Store our name to validate inside a variable
            // Trim it, to remove leading and trailing whitespaces
            string name = nameInputTextBox.Text;
            name.Trim();

            // If the name isn't valid
            if (!NameIsValid(name))
            {
                // Return
                return;
            }

            // Array with all our event check boxes in
            CheckBox[] eventCheckBoxes =
            {
                checkBoxEvent1,
                checkBoxEvent2,
                checkBoxEvent3,
                checkBoxEvent4,
                checkBoxEvent5
            };

            // Counts how many events have been selected
            int numEventsSelected = 0;

            // Loops over radio button
            for (int i = 0; i < 5; i++)
            {
                // if checked, add 1 to num events selected
                if (eventCheckBoxes[i].Checked)
                {
                    numEventsSelected += 1;
                }
            }

            // If num events selected is lower than 4 and they're not in a single event
            if (numEventsSelected < 4 && !singleEventCheckbox.Checked)
            {
                // Display a message box and return
                MessageBox.Show("Each contestant must compete in a minimum of 4 events.\n" +
                    "Please select the checkbox below if this person will only be in 1 event.", "Error");
                return;
            }

            // If in single event but more than one is selected
            if (numEventsSelected > 1 && singleEventCheckbox.Checked)
            {
                // Display a message box and return
                MessageBox.Show("This contestant can only compete in one event.", "Error");
                return;
            }

            // Finally, add all of the contestants to the input and output table
            if (EventScores.ContainsKey(name))
            {
                MessageBox.Show($"{name} has already been entered as a contestant.", "Contestant Already Entered");
                return;
            }

            // Loop through all the radio buttons again
            for (int i = 0; i < 5; i++)
            {
                // If the button is checked but there aren't any spaces left 
                if (eventCheckBoxes[i].Checked && NumSpaces[i] <= 0)
                {
                    // Show an error message, telling the user which event doesn't have any spaces left, then return
                    MessageBox.Show($"There are no more spaces left in the following event: {eventCheckBoxes[i].Text}",
                        "No more spaces");
                    return;
                }

                // If the radio button is checked, and if there is at least one space left in the event
                if (eventCheckBoxes[i].Checked && NumSpaces[i] > 0)
                {
                    // Take one away from the spaces left 
                    NumSpaces[i] -= 1;
                }                
            }         

            // Add the contestant to the event scores dictionary with scores of 0
            // And add them to the events taken part in dictionary, by default they're in all events but we'll change this
            EventScores[name] = new int[5] { 0, 0, 0, 0, 0 };
            IsInEvents[name] = new bool[5] { true, true, true, true, true };

            // Then loop 5 times
            for (int i = 0; i < 5; i++)
            {
                // Update the spaces left list box
                spacesLeftListBox.Items[i] = ($"{eventCheckBoxes[i].Text} | Spaces: {NumSpaces[i]}");

                // If the contestant isn't in the event
                if (!eventCheckBoxes[i].Checked)
                {
                    // Set the bool that tells us if they take part in that event to false
                    IsInEvents[name][i] = false;
                }          
            }

            // This will store how many events have no spaces
            int numEventsWithNoSpaces = 0;
            
            // Loop over all the events
            for (int i = 0; i < NumSpaces.Length; i++)
            {
                // If the event has no spaces
                if (NumSpaces[i] == 0)
                {
                    // Add 1 to the counter
                    numEventsWithNoSpaces++;
                }
            }

            // If no events have spaces, all of the contestants have been entered
            if (numEventsWithNoSpaces == 5)
            {
                // So we can enable the event view tab and output tab
                ((Control)eventViewTab).Enabled = true;
                ((Control)totalsOutputTab).Enabled = true;

                // And then disable to two setup tabs 
                ((Control)setUpEventsPage).Enabled = false;
                ((Control)enterContestantsPage).Enabled = false;

                // Then enable write to file button and clear data button
                writeToFileButton.Enabled = true;
                clearDataButton.Enabled = true;

                // Show messagebox on successful entry of contestants 
                MessageBox.Show("All contestants have successfully been entered.", "Set Up Complete");
            }
        }

        /// <summary>
        /// This is run if the user clicks 'Write to File.' Opens a new window prompting the user to input a path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void writeToFileButton_Click(object sender, EventArgs e)
        {
            // Create an array to store all of the scores in
            // Set the length to the number of scores there are, so we have the right amount of items
            string[] scoresArray = new string[EventScores.Count];

            // For each empty item in the array that will store our scores as a string
            for (int i = 0; i < scoresArray.Length; i++)
            {
                // Add the contestant's name, which is the key of either eventScores or totalScores
                // I'm using eventScores but it doesn't really matter which one I use.
                scoresArray[i] = $"{EventScores.ElementAt(i).Key}: ";

                // Loop through each score for that competitor. It's stored in an array as the value
                for (int j = 0; j < EventScores.ElementAt(i).Value.Length; j++)
                {
                    // Add each score (each j) for the competitor (each i) to the string 
                    scoresArray[i] += $"{EventScores.ElementAt(i).Value[j]} ";
                }

                // Finally, add the total score for that competitor to the string
                // Then move on to the next so that we have a string representation of their scores 
                scoresArray[i] += $"| Total: {TotalScores.ElementAt(i).Value}";
            }

            // Create a new SaveFileDialog, which gives the user a GUI for saving a file
            SaveFileDialog writeToFileDialog = new SaveFileDialog();

            // Filter the types of file the results can be saved to, to .txt files only
            // Set the SaveFileDialog's title text to "Save Results"
            // Set the directory the UI opens at to C:\ drive
            // RestoreDirectory = True means that it restores the current directory before closing
            // Set the default file extension to .txt to make it easier to use
            writeToFileDialog.Filter = "Text Files (*.txt)|*.txt";
            writeToFileDialog.Title = "Save Results";
            writeToFileDialog.InitialDirectory = @"C:\";
            writeToFileDialog.RestoreDirectory = true;
            writeToFileDialog.DefaultExt = "txt";

            // Displays a message box if the file path doesn't exist
            // Then display the save file dialog screen
            writeToFileDialog.CheckPathExists = true;

            // Create variable to store file path in
            string fileName; 

            // Shows the save file GUI, this code runs when the user clicks OK
            if (writeToFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set file path to file name user selects               
                fileName = writeToFileDialog.FileName;

                // Then create a new streamWriter object to write to that file
                StreamWriter fileWriterObj = new StreamWriter(fileName);

                // Then for each contestant in the string representation of our scores
                for (int k = 0; k < scoresArray.Length; k++)
                {
                    // Write it as a separate line in the .txt file
                    fileWriterObj.WriteLine(scoresArray[k]);
                }

                // Then close our StreamWriter to save 
                // And display a message saying the file has been saved
                fileWriterObj.Close();
                MessageBox.Show("The scores have been successfully saved.", "Success");
            }
        }
 
        /// <summary>
        /// Run if the user clicks clear all data. Opens up a confirmation pop up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void clearDataButton_Click(object sender, EventArgs e)
        {
            // Instantiate the clear data popup form
            // Then show the form
            ClearDataConfirmationPopUp clearDataPopup = new ClearDataConfirmationPopUp();
            clearDataPopup.Show();
        }

        /// <summary>
        /// Run if the user clicks the 'Sort (Low to High)' button on the output tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void sortByAscendingButton_Click(object sender, EventArgs e)
        {
            // Call sort method to sort the dictionary by value
            // And copy  the data from the dictionary to the output table
            TotalScores = SortLowToHigh(TotalScores);
            OutputTotalScores();
        }

        /// <summary>
        /// Run if the user clicks the 'Sort (High to Low)' button in the output tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void sortByDescendingButton_Click(object sender, EventArgs e)
        {
            // Call sort method to sort the dictionary by value
            // And copy  the data from the dictionary to the output table
            TotalScores = SortHighToLow(TotalScores);
            OutputTotalScores();
        }     

        /// <summary>
        /// This code is run if the user edits a value in a cell in the event scores output table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void eventResultsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Guard clause to check if the table has no items
            if (eventResultsTable.Rows.Count < 1)
            {
                // If no items, return
                return;
            }

            // Gets the indexes of the changed cell
            int changedRowIndex = e.RowIndex;
            int changedColIndex = e.ColumnIndex;

            // Gets the new value that has been entered, so that we can change the score to it 
            string changedRankToValidate = eventResultsTable.Rows[changedRowIndex].Cells[changedColIndex].Value.ToString();

            // If the changed rank is invalid
            if (!RankIsValid(changedRankToValidate, changedColIndex - 1))
            {
                // Return
                return;
            }

            // If not then convert it to and integer
            int changedRank = int.Parse(changedRankToValidate);

            // On the same row as the cell value that was changed, find the name associated with it
            // We can simply use the changed row index, to get the row, and cells[0] to get the first col, which is name
            string name = eventResultsTable.Rows[changedRowIndex].Cells[0].Value.ToString();

            // Loop through all of the event scores
            foreach (KeyValuePair<string, int[]> contestant in EventScores)
            {
                // If the name is in there
                if (name == contestant.Key)
                {
                    // Set the value at index changedColIndex to the changed value
                    // This is because in the DGV, event 1 is at col index 1, event 2 is at col index 2 etc..
                    // But in eventScores, the value is an array where event 1 is index 0, event 2 is index 1 etc..
                    contestant.Value[changedColIndex - 1] = NumEntrants[changedColIndex - 1] + 1 - changedRank; 
                }
            }

            // Then finally update total scores
            UpdateTotalScores();
        }

        /// <summary>
        /// If the user changes the value in the combo box labeled 'view by:' run this code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void eventViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the user chooses to view the event output table by scores...
            // Copy data accross from event scores dictionary
            // If no view is selected, it shows scores by default
            // Scores is the first option so its index is 0, an index of -1 means nothing is selected
            if (eventViewComboBox.SelectedIndex <= 0)
            {
                OutputEventScores();

                // If viewing by score, we don't want the user to edit anything
                eventResultsTable.ReadOnly = true;

                RestrictRankInputs();
            }

            // If the user chooses to view the event output table by rank
            // Convert the event scores to ranks and then copy it to the DGV
            // Ranks is the second option so its index is 1
            else if (eventViewComboBox.SelectedIndex == 1)
            {
                ShowEventRanksIO();

                // If viewing by rank, we want them to be able to edit it so set read only to true
                eventResultsTable.ReadOnly = false;

                // Disable inputs for all the cells where a contestant isn't in an event
                RestrictRankInputs();
            }
        }

        /// <summary>
        /// This is run when the user has finished setting up the events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void finishEventSetup_Click(object sender, EventArgs e)
        {
            // Create an array of all of our event name text boxes to loop over           
            TextBox[] eventNameTextboxes =
            {
                event1NameTextBox,
                event2NameTextBox,
                event3NameTextBox,
                event4NameTextBox,
                event5NameTextBox
            };

            // Create an array of all of our num. contestant numericUpDowns to loop over
            NumericUpDown[] numContestantTextBoxes =
            {
                event1NumContestants,
                event2NumContestants,
                event3NumContestants,
                event4NumContestants,
                event5NumContestants
            };

            // Array of all our checkboxes for the events
            CheckBox[] eventCheckBoxes =
            {
                checkBoxEvent1,
                checkBoxEvent2,
                checkBoxEvent3,
                checkBoxEvent4,
                checkBoxEvent5
            };

            // For each of the events
            for (int i = 0; i < 5; i++)
            {
                // Store the current event's name and num. contestants in variables
                string currentEventName = eventNameTextboxes[i].Text;
                int currentEventNumContestants = (int)numContestantTextBoxes[i].Value;

                // Remove whitespaces from the event name         
                currentEventName.Trim();

                // Then validate the event name              
                if (!EventNameIsValid(currentEventName, i))
                {
                    // Return (do nothing)
                    return;
                }

                // Then change the options for selecting an event 
                // And the name of each event in the event view
                eventCheckBoxes[i].Text = currentEventName;
                eventResultsTable.Columns[i + 1].HeaderText = currentEventName;

                // Then add the num contestants in the event to the array
                NumEntrants[i] = currentEventNumContestants;
                NumSpaces[i] = NumEntrants[i];

                // Then add the event to the list box on the enter contestants page that shows spaces left
                spacesLeftListBox.Items.Add($"{eventCheckBoxes[i].Text} | Spaces: {(int)numContestantTextBoxes[i].Value}");
            }

            // Show the set up contestants page next
            // Then set num spaces left to nums of contestants
            ((Control)enterContestantsPage).Enabled = true;
            ((Control)setUpEventsPage).Enabled = false;

            // Show a message box after successful setup
            MessageBox.Show("The tournament's events have been set up successfully.", "Set Up Complete");          
        }        

        /// <summary>
        /// This code runs when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ScoringProgram_Load(object sender, EventArgs e)
        {
            // Selects view by rank by default
            eventViewComboBox.SelectedIndex = 1;

            // For each of the pages in our tabcontrol
            foreach (TabPage tp in tabControl.TabPages)
            {
                // Disable all of them except the set up events page
                if (tp.Name != "setUpEventsPage")
                {
                    ((Control)tp).Enabled = false;
                }            
            }

            // Disable uneeded buttons before set up has finshed
            writeToFileButton.Enabled = false;
            clearDataButton.Enabled = false;
        }

        #endregion
    }
}
