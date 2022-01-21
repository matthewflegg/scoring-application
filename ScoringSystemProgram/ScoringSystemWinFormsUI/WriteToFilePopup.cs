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
    public partial class WriteToFilePopup : Form
    {
        #region Constructor 

        /// <summary>
        /// Passes in the total scores dictionary, which lets us use it in this form.
        /// </summary>
        /// <param name="aTotalScoresCopy"></param>

        public WriteToFilePopup()
        {
            // Set the totalScoresCopy property to the parameter passed in
            InitializeComponent();
        }

        #endregion

        #region Event Methods

        /// <summary>
        /// Run when the user clicks the enter file path button. Writes score data to a .txt file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonEnterFilePath_Click(object sender, EventArgs e)
        {
            // Get the text inside it and store it in a variable
            // Create a new StreamWriter object to write to a file
            string filePath = textboxFilePath.Text;   
            StreamWriter sw = new StreamWriter(filePath);

            // Get the total scores dictionary from Initialisation.scoringProgramMainWindow.totalscores
            IDictionary<string, int> totalScores = Initialisation.scoringProgramMainWindow.totalScores;

            // For each item in the total scores dictionary (each contestant)
            foreach (KeyValuePair<string, int> entry in totalScores)
            {
                // Write the key (their name) then a ":", then the value (their total score)
                sw.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // Close StreamWriter to output
            sw.Close();

            // Display a success message dialog box
            // Then close the write to file pop-up window
            MessageBox.Show($"Scores successfully saved to {filePath}.", "Success");
            this.Close();
        }

        #endregion
    }
}
