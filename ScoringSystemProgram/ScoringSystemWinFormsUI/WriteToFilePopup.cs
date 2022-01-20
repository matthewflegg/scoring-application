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
        #region Properties

        // A copy of the dictionary containing the total scores
        public IDictionary<string, int> totalScoresCopy = new Dictionary<string, int>();

        #endregion

        #region Constructor 

        /// <summary>
        /// Passes in the total scores dictionary, which lets us use it in this form.
        /// </summary>
        /// <param name="aTotalScoresCopy"></param>

        public WriteToFilePopup(IDictionary<string, int> aTotalScoresCopy)
        {
            // Set the totalScoresCopy property to the parameter passed in
            InitializeComponent();
            totalScoresCopy = aTotalScoresCopy;
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

            // For each item in the total scores dictionary (each contestant)
            foreach (KeyValuePair<string, int> entry in totalScoresCopy)
            {
                // Write the key (their name) then a ":", then the value (their total score)
                sw.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // Close StreamWriter to output
            sw.Close();

            // Display a success message dialog box
            // Then close the write to file pop-up window
            MessageBox.Show($"Scores successfully saved to {filePath}.");
            this.Close();
        }

        #endregion
    }
}
