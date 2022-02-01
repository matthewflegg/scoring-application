
namespace ScoringSystemWinFormsUI
{
    partial class ScoringProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoringProgram));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.setUpEventsPage = new System.Windows.Forms.TabPage();
            this.finishEventSetup = new System.Windows.Forms.Button();
            this.numContestantsGroupBox = new System.Windows.Forms.GroupBox();
            this.event5NumContestantsLabel = new System.Windows.Forms.Label();
            this.event4NumContestantsLabel = new System.Windows.Forms.Label();
            this.event3NumContestantsLabel = new System.Windows.Forms.Label();
            this.event2NumContestantsLabel = new System.Windows.Forms.Label();
            this.event1NumContestantsLabel = new System.Windows.Forms.Label();
            this.event5NumContestants = new System.Windows.Forms.NumericUpDown();
            this.event4NumContestants = new System.Windows.Forms.NumericUpDown();
            this.event3NumContestants = new System.Windows.Forms.NumericUpDown();
            this.event2NumContestants = new System.Windows.Forms.NumericUpDown();
            this.event1NumContestants = new System.Windows.Forms.NumericUpDown();
            this.eventNamesGroupBox = new System.Windows.Forms.GroupBox();
            this.event5NameLabel = new System.Windows.Forms.Label();
            this.event4NameLabel = new System.Windows.Forms.Label();
            this.event3NameLabel = new System.Windows.Forms.Label();
            this.event2NameLabel = new System.Windows.Forms.Label();
            this.event1NameLabel = new System.Windows.Forms.Label();
            this.event5NameTextBox = new System.Windows.Forms.TextBox();
            this.event4NameTextBox = new System.Windows.Forms.TextBox();
            this.event3NameTextBox = new System.Windows.Forms.TextBox();
            this.event2NameTextBox = new System.Windows.Forms.TextBox();
            this.event1NameTextBox = new System.Windows.Forms.TextBox();
            this.inputTab = new System.Windows.Forms.TabPage();
            this.nameInputComboBox = new System.Windows.Forms.ComboBox();
            this.rankInputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.eventInputComboBox = new System.Windows.Forms.ComboBox();
            this.enterInputButton = new System.Windows.Forms.Button();
            this.rankInputLabel = new System.Windows.Forms.Label();
            this.eventInputLabel = new System.Windows.Forms.Label();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.eventViewTab = new System.Windows.Forms.TabPage();
            this.viewByLabel = new System.Windows.Forms.Label();
            this.eventViewComboBox = new System.Windows.Forms.ComboBox();
            this.eventResultsTable = new System.Windows.Forms.DataGridView();
            this.contestantNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event1ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event2ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event3ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event4ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event5ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsOutputTab = new System.Windows.Forms.TabPage();
            this.sortByDescendingButton = new System.Windows.Forms.Button();
            this.sortByAscendingButton = new System.Windows.Forms.Button();
            this.totalScoresOutputTable = new System.Windows.Forms.DataGridView();
            this.contestantNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalScoreTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writeToFileButton = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.setUpEventsPage.SuspendLayout();
            this.numContestantsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.event5NumContestants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event4NumContestants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event3NumContestants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event2NumContestants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event1NumContestants)).BeginInit();
            this.eventNamesGroupBox.SuspendLayout();
            this.inputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankInputNumericUpDown)).BeginInit();
            this.eventViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventResultsTable)).BeginInit();
            this.totalsOutputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalScoresOutputTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.setUpEventsPage);
            this.tabControl.Controls.Add(this.inputTab);
            this.tabControl.Controls.Add(this.eventViewTab);
            this.tabControl.Controls.Add(this.totalsOutputTab);
            this.tabControl.Location = new System.Drawing.Point(12, 45);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(515, 251);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // setUpEventsPage
            // 
            this.setUpEventsPage.Controls.Add(this.finishEventSetup);
            this.setUpEventsPage.Controls.Add(this.numContestantsGroupBox);
            this.setUpEventsPage.Controls.Add(this.eventNamesGroupBox);
            this.setUpEventsPage.Location = new System.Drawing.Point(4, 22);
            this.setUpEventsPage.Name = "setUpEventsPage";
            this.setUpEventsPage.Size = new System.Drawing.Size(507, 225);
            this.setUpEventsPage.TabIndex = 3;
            this.setUpEventsPage.Text = "Set Up Events";
            this.setUpEventsPage.UseVisualStyleBackColor = true;
            // 
            // finishEventSetup
            // 
            this.finishEventSetup.Location = new System.Drawing.Point(14, 188);
            this.finishEventSetup.Name = "finishEventSetup";
            this.finishEventSetup.Size = new System.Drawing.Size(75, 23);
            this.finishEventSetup.TabIndex = 4;
            this.finishEventSetup.Text = "Finish";
            this.finishEventSetup.UseVisualStyleBackColor = true;
            this.finishEventSetup.Click += new System.EventHandler(this.finishEventSetup_Click);
            // 
            // numContestantsGroupBox
            // 
            this.numContestantsGroupBox.Controls.Add(this.event5NumContestantsLabel);
            this.numContestantsGroupBox.Controls.Add(this.event4NumContestantsLabel);
            this.numContestantsGroupBox.Controls.Add(this.event3NumContestantsLabel);
            this.numContestantsGroupBox.Controls.Add(this.event2NumContestantsLabel);
            this.numContestantsGroupBox.Controls.Add(this.event1NumContestantsLabel);
            this.numContestantsGroupBox.Controls.Add(this.event5NumContestants);
            this.numContestantsGroupBox.Controls.Add(this.event4NumContestants);
            this.numContestantsGroupBox.Controls.Add(this.event3NumContestants);
            this.numContestantsGroupBox.Controls.Add(this.event2NumContestants);
            this.numContestantsGroupBox.Controls.Add(this.event1NumContestants);
            this.numContestantsGroupBox.Location = new System.Drawing.Point(264, 14);
            this.numContestantsGroupBox.Name = "numContestantsGroupBox";
            this.numContestantsGroupBox.Size = new System.Drawing.Size(229, 168);
            this.numContestantsGroupBox.TabIndex = 1;
            this.numContestantsGroupBox.TabStop = false;
            this.numContestantsGroupBox.Text = "Enter the No. of Contestants in Each Event";
            // 
            // event5NumContestantsLabel
            // 
            this.event5NumContestantsLabel.AutoSize = true;
            this.event5NumContestantsLabel.Location = new System.Drawing.Point(6, 135);
            this.event5NumContestantsLabel.Name = "event5NumContestantsLabel";
            this.event5NumContestantsLabel.Size = new System.Drawing.Size(47, 13);
            this.event5NumContestantsLabel.TabIndex = 9;
            this.event5NumContestantsLabel.Text = "Event 5:";
            // 
            // event4NumContestantsLabel
            // 
            this.event4NumContestantsLabel.AutoSize = true;
            this.event4NumContestantsLabel.Location = new System.Drawing.Point(6, 108);
            this.event4NumContestantsLabel.Name = "event4NumContestantsLabel";
            this.event4NumContestantsLabel.Size = new System.Drawing.Size(47, 13);
            this.event4NumContestantsLabel.TabIndex = 8;
            this.event4NumContestantsLabel.Text = "Event 4:";
            // 
            // event3NumContestantsLabel
            // 
            this.event3NumContestantsLabel.AutoSize = true;
            this.event3NumContestantsLabel.Location = new System.Drawing.Point(6, 81);
            this.event3NumContestantsLabel.Name = "event3NumContestantsLabel";
            this.event3NumContestantsLabel.Size = new System.Drawing.Size(47, 13);
            this.event3NumContestantsLabel.TabIndex = 7;
            this.event3NumContestantsLabel.Text = "Event 3:";
            // 
            // event2NumContestantsLabel
            // 
            this.event2NumContestantsLabel.AutoSize = true;
            this.event2NumContestantsLabel.Location = new System.Drawing.Point(6, 54);
            this.event2NumContestantsLabel.Name = "event2NumContestantsLabel";
            this.event2NumContestantsLabel.Size = new System.Drawing.Size(47, 13);
            this.event2NumContestantsLabel.TabIndex = 6;
            this.event2NumContestantsLabel.Text = "Event 2:";
            // 
            // event1NumContestantsLabel
            // 
            this.event1NumContestantsLabel.AutoSize = true;
            this.event1NumContestantsLabel.Location = new System.Drawing.Point(6, 28);
            this.event1NumContestantsLabel.Name = "event1NumContestantsLabel";
            this.event1NumContestantsLabel.Size = new System.Drawing.Size(47, 13);
            this.event1NumContestantsLabel.TabIndex = 5;
            this.event1NumContestantsLabel.Text = "Event 1:";
            // 
            // event5NumContestants
            // 
            this.event5NumContestants.Location = new System.Drawing.Point(59, 132);
            this.event5NumContestants.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.event5NumContestants.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.event5NumContestants.Name = "event5NumContestants";
            this.event5NumContestants.ReadOnly = true;
            this.event5NumContestants.Size = new System.Drawing.Size(164, 20);
            this.event5NumContestants.TabIndex = 4;
            this.event5NumContestants.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // event4NumContestants
            // 
            this.event4NumContestants.Location = new System.Drawing.Point(59, 105);
            this.event4NumContestants.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.event4NumContestants.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.event4NumContestants.Name = "event4NumContestants";
            this.event4NumContestants.ReadOnly = true;
            this.event4NumContestants.Size = new System.Drawing.Size(164, 20);
            this.event4NumContestants.TabIndex = 3;
            this.event4NumContestants.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // event3NumContestants
            // 
            this.event3NumContestants.Location = new System.Drawing.Point(59, 78);
            this.event3NumContestants.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.event3NumContestants.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.event3NumContestants.Name = "event3NumContestants";
            this.event3NumContestants.ReadOnly = true;
            this.event3NumContestants.Size = new System.Drawing.Size(164, 20);
            this.event3NumContestants.TabIndex = 2;
            this.event3NumContestants.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // event2NumContestants
            // 
            this.event2NumContestants.Location = new System.Drawing.Point(59, 51);
            this.event2NumContestants.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.event2NumContestants.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.event2NumContestants.Name = "event2NumContestants";
            this.event2NumContestants.ReadOnly = true;
            this.event2NumContestants.Size = new System.Drawing.Size(164, 20);
            this.event2NumContestants.TabIndex = 1;
            this.event2NumContestants.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // event1NumContestants
            // 
            this.event1NumContestants.Location = new System.Drawing.Point(59, 26);
            this.event1NumContestants.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.event1NumContestants.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.event1NumContestants.Name = "event1NumContestants";
            this.event1NumContestants.ReadOnly = true;
            this.event1NumContestants.Size = new System.Drawing.Size(164, 20);
            this.event1NumContestants.TabIndex = 0;
            this.event1NumContestants.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // eventNamesGroupBox
            // 
            this.eventNamesGroupBox.Controls.Add(this.event5NameLabel);
            this.eventNamesGroupBox.Controls.Add(this.event4NameLabel);
            this.eventNamesGroupBox.Controls.Add(this.event3NameLabel);
            this.eventNamesGroupBox.Controls.Add(this.event2NameLabel);
            this.eventNamesGroupBox.Controls.Add(this.event1NameLabel);
            this.eventNamesGroupBox.Controls.Add(this.event5NameTextBox);
            this.eventNamesGroupBox.Controls.Add(this.event4NameTextBox);
            this.eventNamesGroupBox.Controls.Add(this.event3NameTextBox);
            this.eventNamesGroupBox.Controls.Add(this.event2NameTextBox);
            this.eventNamesGroupBox.Controls.Add(this.event1NameTextBox);
            this.eventNamesGroupBox.Location = new System.Drawing.Point(14, 14);
            this.eventNamesGroupBox.Name = "eventNamesGroupBox";
            this.eventNamesGroupBox.Size = new System.Drawing.Size(244, 168);
            this.eventNamesGroupBox.TabIndex = 0;
            this.eventNamesGroupBox.TabStop = false;
            this.eventNamesGroupBox.Text = "Enter the Names for Each Event";
            // 
            // event5NameLabel
            // 
            this.event5NameLabel.AutoSize = true;
            this.event5NameLabel.Location = new System.Drawing.Point(6, 135);
            this.event5NameLabel.Name = "event5NameLabel";
            this.event5NameLabel.Size = new System.Drawing.Size(47, 13);
            this.event5NameLabel.TabIndex = 9;
            this.event5NameLabel.Text = "Event 5:";
            // 
            // event4NameLabel
            // 
            this.event4NameLabel.AutoSize = true;
            this.event4NameLabel.Location = new System.Drawing.Point(6, 108);
            this.event4NameLabel.Name = "event4NameLabel";
            this.event4NameLabel.Size = new System.Drawing.Size(47, 13);
            this.event4NameLabel.TabIndex = 8;
            this.event4NameLabel.Text = "Event 4:";
            // 
            // event3NameLabel
            // 
            this.event3NameLabel.AutoSize = true;
            this.event3NameLabel.Location = new System.Drawing.Point(6, 81);
            this.event3NameLabel.Name = "event3NameLabel";
            this.event3NameLabel.Size = new System.Drawing.Size(47, 13);
            this.event3NameLabel.TabIndex = 7;
            this.event3NameLabel.Text = "Event 3:";
            // 
            // event2NameLabel
            // 
            this.event2NameLabel.AutoSize = true;
            this.event2NameLabel.Location = new System.Drawing.Point(6, 54);
            this.event2NameLabel.Name = "event2NameLabel";
            this.event2NameLabel.Size = new System.Drawing.Size(47, 13);
            this.event2NameLabel.TabIndex = 6;
            this.event2NameLabel.Text = "Event 2:";
            // 
            // event1NameLabel
            // 
            this.event1NameLabel.AutoSize = true;
            this.event1NameLabel.Location = new System.Drawing.Point(6, 28);
            this.event1NameLabel.Name = "event1NameLabel";
            this.event1NameLabel.Size = new System.Drawing.Size(47, 13);
            this.event1NameLabel.TabIndex = 5;
            this.event1NameLabel.Text = "Event 1:";
            // 
            // event5NameTextBox
            // 
            this.event5NameTextBox.Location = new System.Drawing.Point(59, 132);
            this.event5NameTextBox.Name = "event5NameTextBox";
            this.event5NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.event5NameTextBox.TabIndex = 4;
            // 
            // event4NameTextBox
            // 
            this.event4NameTextBox.Location = new System.Drawing.Point(59, 105);
            this.event4NameTextBox.Name = "event4NameTextBox";
            this.event4NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.event4NameTextBox.TabIndex = 3;
            // 
            // event3NameTextBox
            // 
            this.event3NameTextBox.Location = new System.Drawing.Point(59, 78);
            this.event3NameTextBox.Name = "event3NameTextBox";
            this.event3NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.event3NameTextBox.TabIndex = 2;
            // 
            // event2NameTextBox
            // 
            this.event2NameTextBox.Location = new System.Drawing.Point(59, 51);
            this.event2NameTextBox.Name = "event2NameTextBox";
            this.event2NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.event2NameTextBox.TabIndex = 1;
            // 
            // event1NameTextBox
            // 
            this.event1NameTextBox.Location = new System.Drawing.Point(59, 25);
            this.event1NameTextBox.Name = "event1NameTextBox";
            this.event1NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.event1NameTextBox.TabIndex = 0;
            // 
            // inputTab
            // 
            this.inputTab.Controls.Add(this.nameInputComboBox);
            this.inputTab.Controls.Add(this.rankInputNumericUpDown);
            this.inputTab.Controls.Add(this.eventInputComboBox);
            this.inputTab.Controls.Add(this.enterInputButton);
            this.inputTab.Controls.Add(this.rankInputLabel);
            this.inputTab.Controls.Add(this.eventInputLabel);
            this.inputTab.Controls.Add(this.nameInputLabel);
            this.inputTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputTab.Location = new System.Drawing.Point(4, 22);
            this.inputTab.Name = "inputTab";
            this.inputTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputTab.Size = new System.Drawing.Size(507, 225);
            this.inputTab.TabIndex = 0;
            this.inputTab.Text = "Enter Contestant Results";
            this.inputTab.UseVisualStyleBackColor = true;
            // 
            // nameInputComboBox
            // 
            this.nameInputComboBox.FormattingEnabled = true;
            this.nameInputComboBox.Location = new System.Drawing.Point(128, 29);
            this.nameInputComboBox.Name = "nameInputComboBox";
            this.nameInputComboBox.Size = new System.Drawing.Size(139, 21);
            this.nameInputComboBox.TabIndex = 8;
            // 
            // rankInputNumericUpDown
            // 
            this.rankInputNumericUpDown.Location = new System.Drawing.Point(128, 82);
            this.rankInputNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rankInputNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rankInputNumericUpDown.Name = "rankInputNumericUpDown";
            this.rankInputNumericUpDown.ReadOnly = true;
            this.rankInputNumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.rankInputNumericUpDown.TabIndex = 7;
            this.rankInputNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // eventInputComboBox
            // 
            this.eventInputComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.eventInputComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.eventInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventInputComboBox.FormattingEnabled = true;
            this.eventInputComboBox.Location = new System.Drawing.Point(128, 55);
            this.eventInputComboBox.Name = "eventInputComboBox";
            this.eventInputComboBox.Size = new System.Drawing.Size(139, 21);
            this.eventInputComboBox.TabIndex = 6;
            // 
            // enterInputButton
            // 
            this.enterInputButton.BackColor = System.Drawing.Color.Transparent;
            this.enterInputButton.Location = new System.Drawing.Point(128, 108);
            this.enterInputButton.Name = "enterInputButton";
            this.enterInputButton.Size = new System.Drawing.Size(75, 23);
            this.enterInputButton.TabIndex = 3;
            this.enterInputButton.Text = "Enter";
            this.enterInputButton.UseVisualStyleBackColor = false;
            this.enterInputButton.Click += new System.EventHandler(this.enterInputButton_Click);
            // 
            // rankInputLabel
            // 
            this.rankInputLabel.AutoSize = true;
            this.rankInputLabel.Location = new System.Drawing.Point(29, 85);
            this.rankInputLabel.Name = "rankInputLabel";
            this.rankInputLabel.Size = new System.Drawing.Size(61, 13);
            this.rankInputLabel.TabIndex = 2;
            this.rankInputLabel.Text = "Enter Rank";
            // 
            // eventInputLabel
            // 
            this.eventInputLabel.AutoSize = true;
            this.eventInputLabel.Location = new System.Drawing.Point(29, 58);
            this.eventInputLabel.Name = "eventInputLabel";
            this.eventInputLabel.Size = new System.Drawing.Size(68, 13);
            this.eventInputLabel.TabIndex = 1;
            this.eventInputLabel.Text = "Select Event";
            // 
            // nameInputLabel
            // 
            this.nameInputLabel.AutoSize = true;
            this.nameInputLabel.Location = new System.Drawing.Point(29, 32);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(63, 13);
            this.nameInputLabel.TabIndex = 0;
            this.nameInputLabel.Text = "Enter Name";
            // 
            // eventViewTab
            // 
            this.eventViewTab.Controls.Add(this.viewByLabel);
            this.eventViewTab.Controls.Add(this.eventViewComboBox);
            this.eventViewTab.Controls.Add(this.eventResultsTable);
            this.eventViewTab.Location = new System.Drawing.Point(4, 22);
            this.eventViewTab.Name = "eventViewTab";
            this.eventViewTab.Size = new System.Drawing.Size(507, 225);
            this.eventViewTab.TabIndex = 2;
            this.eventViewTab.Text = "View & Edit Event Results";
            this.eventViewTab.UseVisualStyleBackColor = true;
            // 
            // viewByLabel
            // 
            this.viewByLabel.AutoSize = true;
            this.viewByLabel.Location = new System.Drawing.Point(3, 11);
            this.viewByLabel.Name = "viewByLabel";
            this.viewByLabel.Size = new System.Drawing.Size(48, 13);
            this.viewByLabel.TabIndex = 2;
            this.viewByLabel.Text = "View By:";
            // 
            // eventViewComboBox
            // 
            this.eventViewComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.eventViewComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.eventViewComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventViewComboBox.FormattingEnabled = true;
            this.eventViewComboBox.Items.AddRange(new object[] {
            "Score",
            "Rank"});
            this.eventViewComboBox.Location = new System.Drawing.Point(57, 8);
            this.eventViewComboBox.Name = "eventViewComboBox";
            this.eventViewComboBox.Size = new System.Drawing.Size(155, 21);
            this.eventViewComboBox.TabIndex = 1;
            this.eventViewComboBox.SelectedIndexChanged += new System.EventHandler(this.eventViewComboBox_SelectedIndexChanged);
            // 
            // eventResultsTable
            // 
            this.eventResultsTable.AllowUserToAddRows = false;
            this.eventResultsTable.AllowUserToDeleteRows = false;
            this.eventResultsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventResultsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contestantNameColumn,
            this.event1ScoreColumn,
            this.event2ScoreColumn,
            this.event3ScoreColumn,
            this.event4ScoreColumn,
            this.event5ScoreColumn});
            this.eventResultsTable.Location = new System.Drawing.Point(4, 38);
            this.eventResultsTable.Name = "eventResultsTable";
            this.eventResultsTable.ReadOnly = true;
            this.eventResultsTable.Size = new System.Drawing.Size(500, 195);
            this.eventResultsTable.TabIndex = 0;
            this.eventResultsTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventResultsTable_CellValueChanged);
            // 
            // contestantNameColumn
            // 
            this.contestantNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contestantNameColumn.HeaderText = "Name";
            this.contestantNameColumn.Name = "contestantNameColumn";
            this.contestantNameColumn.ReadOnly = true;
            // 
            // event1ScoreColumn
            // 
            this.event1ScoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event1ScoreColumn.HeaderText = "-";
            this.event1ScoreColumn.Name = "event1ScoreColumn";
            this.event1ScoreColumn.ReadOnly = true;
            // 
            // event2ScoreColumn
            // 
            this.event2ScoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event2ScoreColumn.HeaderText = "-";
            this.event2ScoreColumn.Name = "event2ScoreColumn";
            this.event2ScoreColumn.ReadOnly = true;
            // 
            // event3ScoreColumn
            // 
            this.event3ScoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event3ScoreColumn.HeaderText = "-";
            this.event3ScoreColumn.Name = "event3ScoreColumn";
            this.event3ScoreColumn.ReadOnly = true;
            // 
            // event4ScoreColumn
            // 
            this.event4ScoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event4ScoreColumn.HeaderText = "-";
            this.event4ScoreColumn.Name = "event4ScoreColumn";
            this.event4ScoreColumn.ReadOnly = true;
            // 
            // event5ScoreColumn
            // 
            this.event5ScoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event5ScoreColumn.HeaderText = "-";
            this.event5ScoreColumn.Name = "event5ScoreColumn";
            this.event5ScoreColumn.ReadOnly = true;
            // 
            // totalsOutputTab
            // 
            this.totalsOutputTab.Controls.Add(this.sortByDescendingButton);
            this.totalsOutputTab.Controls.Add(this.sortByAscendingButton);
            this.totalsOutputTab.Controls.Add(this.totalScoresOutputTable);
            this.totalsOutputTab.Location = new System.Drawing.Point(4, 22);
            this.totalsOutputTab.Name = "totalsOutputTab";
            this.totalsOutputTab.Padding = new System.Windows.Forms.Padding(3);
            this.totalsOutputTab.Size = new System.Drawing.Size(507, 225);
            this.totalsOutputTab.TabIndex = 1;
            this.totalsOutputTab.Text = "View Scores by Total";
            this.totalsOutputTab.UseVisualStyleBackColor = true;
            // 
            // sortByDescendingButton
            // 
            this.sortByDescendingButton.Location = new System.Drawing.Point(119, 6);
            this.sortByDescendingButton.Name = "sortByDescendingButton";
            this.sortByDescendingButton.Size = new System.Drawing.Size(107, 23);
            this.sortByDescendingButton.TabIndex = 2;
            this.sortByDescendingButton.Text = "Sort (High to Low)";
            this.sortByDescendingButton.UseVisualStyleBackColor = true;
            this.sortByDescendingButton.Click += new System.EventHandler(this.sortByDescendingButton_Click);
            // 
            // sortByAscendingButton
            // 
            this.sortByAscendingButton.Location = new System.Drawing.Point(6, 6);
            this.sortByAscendingButton.Name = "sortByAscendingButton";
            this.sortByAscendingButton.Size = new System.Drawing.Size(107, 23);
            this.sortByAscendingButton.TabIndex = 1;
            this.sortByAscendingButton.Text = "Sort (Low to High)";
            this.sortByAscendingButton.UseVisualStyleBackColor = true;
            this.sortByAscendingButton.Click += new System.EventHandler(this.sortByAscendingButton_Click);
            // 
            // totalScoresOutputTable
            // 
            this.totalScoresOutputTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalScoresOutputTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.totalScoresOutputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalScoresOutputTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contestantNameTextBoxColumn,
            this.totalScoreTextBoxColumn});
            this.totalScoresOutputTable.Location = new System.Drawing.Point(6, 35);
            this.totalScoresOutputTable.Name = "totalScoresOutputTable";
            this.totalScoresOutputTable.Size = new System.Drawing.Size(495, 195);
            this.totalScoresOutputTable.TabIndex = 0;
            // 
            // contestantNameTextBoxColumn
            // 
            this.contestantNameTextBoxColumn.HeaderText = "Contestant Name";
            this.contestantNameTextBoxColumn.Name = "contestantNameTextBoxColumn";
            this.contestantNameTextBoxColumn.ReadOnly = true;
            // 
            // totalScoreTextBoxColumn
            // 
            this.totalScoreTextBoxColumn.HeaderText = "Total Score";
            this.totalScoreTextBoxColumn.Name = "totalScoreTextBoxColumn";
            this.totalScoreTextBoxColumn.ReadOnly = true;
            // 
            // writeToFileButton
            // 
            this.writeToFileButton.Location = new System.Drawing.Point(12, 12);
            this.writeToFileButton.Name = "writeToFileButton";
            this.writeToFileButton.Size = new System.Drawing.Size(75, 23);
            this.writeToFileButton.TabIndex = 1;
            this.writeToFileButton.Text = "Write to File";
            this.writeToFileButton.UseVisualStyleBackColor = true;
            this.writeToFileButton.Click += new System.EventHandler(this.writeToFileButton_Click);
            // 
            // clearDataButton
            // 
            this.clearDataButton.Location = new System.Drawing.Point(93, 12);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(75, 23);
            this.clearDataButton.TabIndex = 2;
            this.clearDataButton.Text = "Clear Data";
            this.clearDataButton.UseVisualStyleBackColor = true;
            this.clearDataButton.Click += new System.EventHandler(this.clearDataButton_Click);
            // 
            // ScoringProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 308);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.writeToFileButton);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScoringProgram";
            this.Text = "iScores";
            this.Load += new System.EventHandler(this.ScoringProgram_Load);
            this.tabControl.ResumeLayout(false);
            this.setUpEventsPage.ResumeLayout(false);
            this.numContestantsGroupBox.ResumeLayout(false);
            this.numContestantsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.event5NumContestants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event4NumContestants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event3NumContestants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event2NumContestants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event1NumContestants)).EndInit();
            this.eventNamesGroupBox.ResumeLayout(false);
            this.eventNamesGroupBox.PerformLayout();
            this.inputTab.ResumeLayout(false);
            this.inputTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankInputNumericUpDown)).EndInit();
            this.eventViewTab.ResumeLayout(false);
            this.eventViewTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventResultsTable)).EndInit();
            this.totalsOutputTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.totalScoresOutputTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage inputTab;
        private System.Windows.Forms.TabPage totalsOutputTab;
        private System.Windows.Forms.Button writeToFileButton;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Label rankInputLabel;
        private System.Windows.Forms.Label eventInputLabel;
        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Button enterInputButton;
        private System.Windows.Forms.ComboBox eventInputComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestantNameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalScoreTextBoxColumn;
        private System.Windows.Forms.Button sortByAscendingButton;
        private System.Windows.Forms.Button sortByDescendingButton;
        private System.Windows.Forms.TabPage eventViewTab;
        public System.Windows.Forms.DataGridView totalScoresOutputTable;
        public System.Windows.Forms.DataGridView eventResultsTable;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.NumericUpDown rankInputNumericUpDown;
        private System.Windows.Forms.ComboBox nameInputComboBox;
        private System.Windows.Forms.Label viewByLabel;
        private System.Windows.Forms.ComboBox eventViewComboBox;
        private System.Windows.Forms.TabPage setUpEventsPage;
        private System.Windows.Forms.GroupBox numContestantsGroupBox;
        private System.Windows.Forms.Label event5NumContestantsLabel;
        private System.Windows.Forms.Label event4NumContestantsLabel;
        private System.Windows.Forms.Label event3NumContestantsLabel;
        private System.Windows.Forms.Label event2NumContestantsLabel;
        private System.Windows.Forms.Label event1NumContestantsLabel;
        private System.Windows.Forms.NumericUpDown event5NumContestants;
        private System.Windows.Forms.NumericUpDown event4NumContestants;
        private System.Windows.Forms.NumericUpDown event3NumContestants;
        private System.Windows.Forms.NumericUpDown event2NumContestants;
        private System.Windows.Forms.NumericUpDown event1NumContestants;
        private System.Windows.Forms.GroupBox eventNamesGroupBox;
        private System.Windows.Forms.Label event5NameLabel;
        private System.Windows.Forms.Label event4NameLabel;
        private System.Windows.Forms.Label event3NameLabel;
        private System.Windows.Forms.Label event2NameLabel;
        private System.Windows.Forms.Label event1NameLabel;
        private System.Windows.Forms.TextBox event5NameTextBox;
        private System.Windows.Forms.TextBox event4NameTextBox;
        private System.Windows.Forms.TextBox event3NameTextBox;
        private System.Windows.Forms.TextBox event2NameTextBox;
        private System.Windows.Forms.TextBox event1NameTextBox;
        private System.Windows.Forms.Button finishEventSetup;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestantNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event1ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event2ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event3ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event4ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event5ScoreColumn;
    }
}

