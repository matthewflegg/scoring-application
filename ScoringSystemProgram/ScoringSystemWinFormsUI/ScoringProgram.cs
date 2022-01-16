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
        private Dictionary<string, int[]> eventScores = new Dictionary<string, int[]>();
        private Dictionary<string, int> totalScores = new Dictionary<string, int>();

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
    }
}
