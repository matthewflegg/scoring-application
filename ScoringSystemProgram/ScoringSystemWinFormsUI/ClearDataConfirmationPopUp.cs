using System;
using System.Windows.Forms;

namespace ScoringSystemWinFormsUI
{
    public partial class ClearDataConfirmationPopUp : Form
    {
        #region Constructor

        public ClearDataConfirmationPopUp()
        {
            InitializeComponent();
        }


        #endregion

        #region Event Methods

        /// <summary>
        /// Closes the popup window and does nothing else if the user clicks no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonNo_Click(object sender, EventArgs e)
        {
            // Close window
            this.Close();
        }

        /// <summary>
        /// Calls the SetEmptyDicts method on the main form window. Run if the user clicks yes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonYes_Click(object sender, EventArgs e)
        {
            // Get the event scores from the main window 
            // Then get the total scores from the main window
            DataGridView eventScoresOutputTable = Initialisation.scoringProgramMainWindow.eventResultsTable;
            DataGridView totalScoresOutputTable = Initialisation.scoringProgramMainWindow.totalScoresOutputTable;

            // Call the clear score dictionaries and DGV method for both output tables on the main form 
            // Then show a message saying that the data was cleared successfully
            Initialisation.scoringProgramMainWindow.ClearFieldsAndResetProgram();
            Initialisation.scoringProgramMainWindow.ClearDataGridView(eventScoresOutputTable);
            Initialisation.scoringProgramMainWindow.ClearDataGridView(totalScoresOutputTable);
            MessageBox.Show("The data was cleared successfully.", "Success");

            // Close window
            this.Close();
        }

        #endregion
    }
}
