using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            MinimumSize = new Size(370, 280);
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
        /// Clears all of the data in the output table and refreshes it.
        /// </summary>

        public void ClearDataGridView()
        {
            // If the DataGridView isn't empty
            if (outputTable.Rows.Count > 0)
            {
                // Clear all rows
                // Then refresh
                outputTable.Rows.Clear();
                outputTable.Refresh();
            }
        }
        
        /// <summary>
        /// Sorts an array of a dictionary's values, then matches the values to the correct keys.
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
        /// Copies the data in the total scores dictionary to the output table.
        /// </summary>
        /// <param name="aTotalScores">The total scores dictionary</param>

        private void CopyDataFromTotalScoresToDataGridView(IDictionary<string, int> aTotalScores)
        {
            // Clear table before writing data from totalScores to outputTable
            // Doing this because it prevents duplicated from being added
            ClearDataGridView();

            // ***NOTE*** This only works if totalScores and the outputTable are in the same row

            // Loop over each row of the output table
            for (int i = 0; i < totalScores.Count; i++)
            {
                // Get key and value from totalScores to use for comparisons
                string currentKey = totalScores.ElementAt(i).Key;
                string currentValue = totalScores.ElementAt(i).Value.ToString();

                // If the current key is found in the name column of the output table
                if (currentKey == (string)outputTable.Rows[i].Cells[0].Value)
                {
                    // Set the total score column to the current value... a.k.a current total score
                    outputTable.Rows[i].Cells[1].Value = currentValue;
                }

                else // Else if the key isn't isn't in the name column of the output table
                {
                    // Create a new array that contains the name and total score of a competitor
                    // Add the row to the DataGridView representing the output table
                    string[] newRow = new string[2] { currentKey.ToString(), currentValue.ToString() };
                    outputTable.Rows.Add(newRow);
                }
            }
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
            // Once the selected tab is changed, check if it's the output tab
            if (tabControl.SelectedTab == tabControl.TabPages["outputTab"])
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

                // Then copy the data from the dictionary to the output table
                CopyDataFromTotalScoresToDataGridView(totalScores);
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
            // Show a message box saying that there are no more spaces
            if (eventScores.Count > 10)
            {
                MessageBox.Show("There are no more spaces left in the tournament. There is a maximum of 10", "Error");
                return;
            }

            // If name is left blank 
            if (string.IsNullOrWhiteSpace(nameInputTextBox.Text))
            {
                // Show an error message saying that the name cannot be blank
                MessageBox.Show("You cannot leave the name blank.", "Invalid Input");
                return;
            }

            // If not blank, store the name in 'name.' Use .Trim() to remove all leading and trailing whitespace
            string name = nameInputTextBox.Text.Trim();

            // 'rank' will store the rank if int.TryParse returns true
            // 'isNumber' is true if the text box input could be converted, false if not
            int rank; 
            bool isNumber = int.TryParse(rankInputTextBox.Text, out rank);

            // If the input couldn't be converted to an int
            if (!isNumber)
            {
                // Show an error message saying that their input was not a number
                MessageBox.Show($"'{rankInputTextBox.Text}' is not a valid rank.", "Invalid Input");
                return;
            }

            // If input is less than or equal to zero
            if (rank <= 0)
            {
                // Show an error message saying that their input cannot be less than or equal to zero
                MessageBox.Show($"The rank of contestant cannot be zero or below.", "Invalid Input");
                return;
            }

            // Else if rank is greater than 10
            if (rank > 10)
            {
                // Show an error message saying that their input cannot be greater than 10
                MessageBox.Show("There is a maximum of 10 contestants. Rank cannot be larger than 10.", "Invalid Input");
                return;
            }

            // If event is an empty string
            if (eventInputComboBox.Text == "")
            {
                // Show an error message, saying that the event cannot be left empty
                MessageBox.Show("The event cannot be left empty.", "Invalid Input");
                return;
            }

            // If the item inputted isn't an item in the list of options
            if (!eventInputComboBox.Items.Contains(eventInputComboBox.Text) && eventInputComboBox.Text != "")
            {
                // Show an error message, saying that the string isn't an option on the drop-down list
                MessageBox.Show($"{eventInputComboBox.Text} is an invalid event.", "Invalid Input");
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

            // Finally, reset text boxes. 
            // Reset combo box to unselected value
            // ***NOTE*** Come back to this
            nameInputTextBox.Text = string.Empty;
            rankInputTextBox.Text = string.Empty;
            eventInputComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// This is run if the user clicks 'Write to File.' Opens a new window prompting the user to input a path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void writeToFileButton_Click(object sender, EventArgs e)
        {
            // Instantiate the popup box form
            // Then use writeToFilePopup.Show(); to show the popup
            // Passes in totalScores to the constructor, so we can use it in the write to file form 
            WriteToFilePopup writeToFilePopup = new WriteToFilePopup();
            writeToFilePopup.Show();       
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
            CopyDataFromTotalScoresToDataGridView(totalScores);
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
            CopyDataFromTotalScoresToDataGridView(totalScores);
        }

        #endregion


    }
}
