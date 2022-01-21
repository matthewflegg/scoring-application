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
            // Call the clear score dictionaries and DGV method on the main form 
            // Then show a message saying that the data was cleared successfully
            Initialisation.scoringProgramMainWindow.ClearDictionariesAndDataGridView();
            MessageBox.Show("The data was cleared successfully.", "Success");

            // Close window
            this.Close();
        }

        #endregion
    }
}
