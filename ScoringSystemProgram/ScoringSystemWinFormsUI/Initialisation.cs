using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystemWinFormsUI
{
    static class Initialisation
    {
        #region Properties

        // Create a property that we can access from another class
        public static ScoringProgram scoringProgramMainWindow { get; set; }

        #endregion

        #region Main

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set that property to a new instance of the main form 
            // Then run the main form
            scoringProgramMainWindow = new ScoringProgram();
            Application.Run(scoringProgramMainWindow);
        }

        #endregion
    }
}
