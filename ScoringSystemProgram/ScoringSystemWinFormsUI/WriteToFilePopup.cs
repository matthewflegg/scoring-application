using System;
using System.Collections.Generic;
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
            string filePath = textboxFilePath.Text;

            // If any exceptions are thrown, run catch block for the exception that is thrown
            // If the file is not found, it runs the catch block for the 'FileNotFoundException'
            // If the exception is of any other type, it runs the catch for the generic exception 
            try
            {


                // Create a new StreamWriter object to write to a file
                StreamWriter fileWriter = new StreamWriter(filePath);

                // Get the total scores dictionary from Initialisation.scoringProgramMainWindow.totalscores
                IDictionary<string, int> totalScores = Initialisation.scoringProgramMainWindow.totalScores;

                // For each item in the total scores dictionary (each contestant)
                foreach (KeyValuePair<string, int> entry in totalScores)
                {
                    // Write the key (their name) then a ":", then the value (their total score)
                    fileWriter.WriteLine($"{entry.Key}: {entry.Value}");
                }

                // Close StreamWriter to output
                fileWriter.Close();

                // Display a success message dialog box
                // Then close the write to file pop-up window
                MessageBox.Show($"Scores successfully saved to {filePath}.", "Success");         
            }

            catch (FileNotFoundException) // The code below is run if the file is not found
            {
                // Show a message box informing the user that the file path is not valid
                MessageBox.Show($"The file path '{filePath}' was not found. Please try again.", "File Path Error");
            }

            catch (Exception exception) // Code below is run is there's any other type of error
            {
                // Show a message box with the exception data
                MessageBox.Show($"{exception.ToString()}", "Write to File Error");
            }

            // Close the pop up 
            this.Close();
        }

        #endregion
    }
}
