using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystemWinFormsUI
{
    public partial class ScoringProgram : Form
    {
        #region Constructor

        public ScoringProgram()
        {
            InitializeComponent();
        }

        #endregion

        #region Declaring Score Storage Dictionaries

        // Creating the eventScores and totalScores dictionaries 
        private IDictionary<string, int[]> eventScores = new Dictionary<string, int[]>();
        private IDictionary<string, int> totalScores = new Dictionary<string, int>();

        #endregion

        #region Private Helper Methods

        /// <summary>
        /// Clears all of the data in the eventScores and totalScores dictionaries by assigning them new, empty dicts
        /// </summary>
        /// <param name="eventScores">The dictionary containing the event scores</param>
        /// <param name="totalScores">The dictionary containing the total scores</param>
        
        private void ClearScoreDictionaries(ref Dictionary<string, int[]> eventScores, ref Dictionary<string, int> totalScores)
        {
            // Overwrites data in dicts by assigning them empty dicts
            eventScores = new Dictionary<string, int[]>();
            totalScores = new Dictionary<string, int>();
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
                // If it is, run the code

            }
        }

        /// <summary>
        /// This code is run if the user clicks the enter button on the input tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void enterInputButton_Click(object sender, EventArgs e)
        {
            // Store the inputs in some variables
            string name = nameInputTextBox.Text;
            int rank = int.Parse(rankInputTextBox.Text); // ***TODO*** Change int.Parse to int.TryParse
            int eventNum = eventInputComboBox.SelectedIndex; // ***NOTE*** Maybe selectedIndex - 1? Come back to this

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

        #endregion
    }
}
