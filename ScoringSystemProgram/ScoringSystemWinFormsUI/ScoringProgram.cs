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

            // Set sizes
            MinimumSize = new Size(510, 340);
            MaximumSize = new Size(590, 475);
        }

        #endregion

        #region Declaring Score Storage Dictionaries

        // Creating the eventScores and totalScores dictionaries 
        public IDictionary<string, int[]> eventScores = new Dictionary<string, int[]>();
        public IDictionary<string, int> totalScores = new Dictionary<string, int>();

        #endregion

        #region Helper Methods

        /// <summary>
        /// Clears all of the data in the eventScores and totalScores dictionaries by assigning them new, empty dicts
        /// </summary>
        /// <param name="eventScores">The dictionary containing the event scores</param>
        /// <param name="totalScores">The dictionary containing the total scores</param>
        
        public void ClearDictionaries()
        {
            // Overwrites data in dicts by assigning them empty dicts
            eventScores = new Dictionary<string, int[]>();
            totalScores = new Dictionary<string, int>();       
        }

        /// <summary>
        /// Clears all of the data in a DataGridView and refreshes it.
        /// </summary>

        public void ClearDataGridView(DataGridView dataGridViewToClear)
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

        private IDictionary<string, int> InsertionSortDictionaryByValueAscending(IDictionary<string, int> unsortedDictionary)
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

        private IDictionary<string, int> InsertionSortDictionaryByValueDescending(IDictionary<string, int> unsortedDictionary)
        {
            // Sorts the dictionary by value, in ascending order
            // Then puts it in a new dictionary
            // Them, create an empty dictiary which we'll use to add values to 
            IDictionary<string, int> sortedDictionaryAscending = InsertionSortDictionaryByValueAscending(unsortedDictionary);
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

        private void CopyScoresFromTotalScoresToDataGridView()
        {
            // Clear table before writing data from totalScores to outputTable
            // Doing this because it prevents duplicated from being added
            ClearDataGridView(totalScoresOutputTable);

            // ***NOTE*** This only works if totalScores and the outputTable are in the same row

            // Loop over each row of the output table
            for (int i = 0; i < totalScores.Count; i++)
            {
                // Get key and value from totalScores to use for comparisons
                string currentKey = totalScores.ElementAt(i).Key;
                string currentValue = totalScores.ElementAt(i).Value.ToString();

                // Create a new array that contains the name and total score of a competitor
                // Add the row to the DataGridView representing the output table
                string[] newRow = new string[2] { currentKey.ToString(), currentValue.ToString() };
                totalScoresOutputTable.Rows.Add(newRow);
            }
        }

        /// <summary>
        /// Copies the data in the event scores dictionary to the event scores output table.
        /// </summary>

        private void CopyScoresFromEventScoresToDataGridView()
        {
            // Clear the DGV to prevent duplicates
            ClearDataGridView(eventResultsTable);

            // Loop through each entry in the eventScores dictionary
            // This goes through all of the contestants
            foreach (KeyValuePair<string, int[]> entry in eventScores)
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

        private void ConvertEventScoresToRanksAndCopyToDataGridView()
        {
            // Clear the DGV to prevent duplicates
            ClearDataGridView(eventResultsTable);

            // Loop through each entry in the eventScores dictionary
            // This goes through all of the contestants
            foreach (KeyValuePair<string, int[]> entry in eventScores)
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
                    newRow[i + 1] = (11 - currentValues[i]).ToString();
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
            foreach (KeyValuePair<string, int[]> entry in eventScores)
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
                if (totalScores.ContainsKey(tKey))
                {
                    // Update the value 
                    totalScores[tKey] = tValue;
                }

                else // If the key isn't already in totalScores
                {
                    // Add the temporary key and value to total scores
                    totalScores.Add(new KeyValuePair<string, int>(tKey, tValue));
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
            if (!Regex.IsMatch(nameInput, @"^[a-zA-Z]+$"))
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

        private bool RankIsValid(string rankInput)
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
            if (!isNumber)
            {
                // Display error message and return false
                MessageBox.Show($"{rankInput} is not a valid input for the rank.", "Invalid Input");
                return false;
            }

            // If the rank is above 10
            if (rank > 10)
            {
                // Display error message and return false
                MessageBox.Show("The rank cannot be above 10.", "Invalid Input");
                return false;
            }

            // If the rank is below 1
            if (rank < 1)
            {
                // Display error message and return false
                MessageBox.Show("The rank cannot be below 1.", "Invalid Input");
                return false;
            }

            // If no errors are found, return true
            return true;
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
                CopyScoresFromTotalScoresToDataGridView();
            }

            // Once the selected tab is changed, check if it's the event scores output tab
            else if (tabControl.SelectedTab == tabControl.TabPages["eventViewTab"])
            {
                // Copy scores from dictionary to DGV
                CopyScoresFromEventScoresToDataGridView();
            }
        }

        /// <summary>
        /// This code is run if the user clicks the enter button on the input tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void enterInputButton_Click(object sender, EventArgs e)
        {
            // If the amount of contestants currently in the tournament is greater than 10           
            if (eventScores.Count > 10)
            {
                // Show a message box saying that there are no more spaces
                MessageBox.Show("There are no more spaces left in the tournament. There is a maximum of 10", "Error");
                return;
            }

            // Store our name to validate inside a variable
            // Trim it, to remove leading and trailing whitespaces
            string name = nameInputComboBox.Text;
            name.Trim();

            // If no inputs have been entered, simply do nothing by returning
            if (string.IsNullOrEmpty(name) && eventInputComboBox.SelectedIndex < 0)
            {
                // Return 
                return;
            }

            // If the name isn't valid
            if (!NameIsValid(name))
            {
                // Return
                return;
            }

            // If the item entered manually isn't already an option in the dropdown         
            if (!nameInputComboBox.Items.Contains(name))
            {
                // Add it to the list of options so the user can enter it more easily in future
                nameInputComboBox.Items.Add(name);
            }          


            // Gets the value from a numericUpDown, casts to an int
            // Cannot enter anything other than an int because it increments by 1
            int rank = (int)rankInputNumericUpDown.Value;           

            // If event is an empty string
            if (eventInputComboBox.Text == "")
            {
                // Show an error message, saying that the event cannot be left empty
                MessageBox.Show("The event cannot be left empty.", "Invalid Input");
                return;
            }
        
            // Variable to store the event number 
            int eventNum = eventInputComboBox.SelectedIndex;

            // Set flagging variable, tells us if the name exists in the dictionary
            bool exists = false;

            // Loop through each key value pair in the eventScores dictionary
            foreach (KeyValuePair<string, int[]> entry in eventScores)
            {
                // If name exists
                if (name == entry.Key)
                {
                    // Calculate rank and store in correct col
                    // Set flag to true so we don't run the if statement that adds a new key 
                    // Then break out of the loop because we already found the right key
                    entry.Value[eventNum] = 11 - rank;
                    exists = true;
                    break;
                }
            }

            if (!exists) // If the name isn't a key in eventScores... exists != true
            {
                // Create a new string with the variable 'name'
                // Create new array[] with length 5, each item is 0
                string nKey = name;
                int[] nValue = new int[5] { 0, 0, 0, 0, 0 };

                // Set the value for the event to 11 - rank... set nValue[eventNum] to 11 - rank
                // Then add the new key and new value to the eventScores dictionary
                nValue[eventNum] = 11 - rank;
                eventScores.Add(new KeyValuePair<string, int[]>(nKey, nValue));
            }

            // Then update the total scores
            UpdateTotalScores();

            // Finally, reset text boxes. 
            // Reset combo box to unselected value
            // ***NOTE*** Come back to this
            nameInputComboBox.Text = string.Empty;
            rankInputNumericUpDown.Value = 1;
            eventInputComboBox.SelectedIndex = -1;
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
            string[] scoresArray = new string[eventScores.Count];

            // For each empty item in the array that will store our scores as a string
            for (int i = 0; i < scoresArray.Length; i++)
            {
                // Add the contestant's name, which is the key of either eventScores or totalScores
                // I'm using eventScores but it doesn't really matter which one I use.
                scoresArray[i] = $"{eventScores.ElementAt(i).Key}: ";

                // Loop through each score for that competitor. It's stored in an array as the value
                for (int j = 0; j < eventScores.ElementAt(i).Value.Length; j++)
                {
                    // Add each score (each j) for the competitor (each i) to the string 
                    scoresArray[i] += $"{eventScores.ElementAt(i).Value[j]} ";
                }

                // Finally, add the total score for that competitor to the string
                // Then move on to the next so that we have a string representation of their scores 
                scoresArray[i] += $"| Total: {totalScores.ElementAt(i).Value}";
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
            totalScores = InsertionSortDictionaryByValueAscending(totalScores);
            CopyScoresFromTotalScoresToDataGridView();
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
            totalScores = InsertionSortDictionaryByValueDescending(totalScores);
            CopyScoresFromTotalScoresToDataGridView();
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
            if (!RankIsValid(changedRankToValidate))
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
            foreach (KeyValuePair<string, int[]> contestant in eventScores)
            {
                // If the name is in there
                if (name == contestant.Key)
                {
                    // Set the value at index changedColIndex to the changed value
                    // This is because in the DGV, event 1 is at col index 1, event 2 is at col index 2 etc..
                    // But in eventScores, the value is an array where event 1 is index 0, event 2 is index 1 etc..
                    contestant.Value[changedColIndex - 1] = 11 - changedRank; 
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
                CopyScoresFromEventScoresToDataGridView();

                // If viewing by score, we don't want the user to edit anything
                eventResultsTable.ReadOnly = true;
            }

            // If the user chooses to view the event output table by rank
            // Convert the event scores to ranks and then copy it to the DGV
            // Ranks is the second option so its index is 1
            else if (eventViewComboBox.SelectedIndex == 1)
            {
                ConvertEventScoresToRanksAndCopyToDataGridView();

                // If viewing by rank, we want them to be able to edit it so set read only to true
                eventResultsTable.ReadOnly = false;
            }
        }

        #endregion
    }
}
