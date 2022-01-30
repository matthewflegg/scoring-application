
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
            this.inputTab = new System.Windows.Forms.TabPage();
            this.nameInputComboBox = new System.Windows.Forms.ComboBox();
            this.rankInputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.eventInputComboBox = new System.Windows.Forms.ComboBox();
            this.enterInputButton = new System.Windows.Forms.Button();
            this.rankInputLabel = new System.Windows.Forms.Label();
            this.eventInputLabel = new System.Windows.Forms.Label();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.eventOutputTab = new System.Windows.Forms.TabPage();
            this.eventScoresOutputTable = new System.Windows.Forms.DataGridView();
            this.totalsOutputTab = new System.Windows.Forms.TabPage();
            this.sortByDescendingButton = new System.Windows.Forms.Button();
            this.sortByAscendingButton = new System.Windows.Forms.Button();
            this.totalScoresOutputTable = new System.Windows.Forms.DataGridView();
            this.contestantNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalScoreTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writeToFileButton = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.contestantNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event1ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event2ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event3ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event4ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event5ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.inputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankInputNumericUpDown)).BeginInit();
            this.eventOutputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventScoresOutputTable)).BeginInit();
            this.totalsOutputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalScoresOutputTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.inputTab);
            this.tabControl.Controls.Add(this.eventOutputTab);
            this.tabControl.Controls.Add(this.totalsOutputTab);
            this.tabControl.Location = new System.Drawing.Point(12, 45);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(515, 302);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
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
            this.inputTab.Location = new System.Drawing.Point(4, 22);
            this.inputTab.Name = "inputTab";
            this.inputTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputTab.Size = new System.Drawing.Size(507, 276);
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
            this.eventInputComboBox.FormattingEnabled = true;
            this.eventInputComboBox.Items.AddRange(new object[] {
            "Archery",
            "Chess",
            "Checkers",
            "Cycling",
            "800m"});
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
            // eventOutputTab
            // 
            this.eventOutputTab.Controls.Add(this.eventScoresOutputTable);
            this.eventOutputTab.Location = new System.Drawing.Point(4, 22);
            this.eventOutputTab.Name = "eventOutputTab";
            this.eventOutputTab.Size = new System.Drawing.Size(507, 276);
            this.eventOutputTab.TabIndex = 2;
            this.eventOutputTab.Text = "View Scores by Event";
            this.eventOutputTab.UseVisualStyleBackColor = true;
            // 
            // eventScoresOutputTable
            // 
            this.eventScoresOutputTable.AllowUserToAddRows = false;
            this.eventScoresOutputTable.AllowUserToDeleteRows = false;
            this.eventScoresOutputTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventScoresOutputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventScoresOutputTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contestantNameColumn,
            this.event1ScoreColumn,
            this.event2ScoreColumn,
            this.event3ScoreColumn,
            this.event4ScoreColumn,
            this.event5ScoreColumn});
            this.eventScoresOutputTable.Location = new System.Drawing.Point(4, 4);
            this.eventScoresOutputTable.Name = "eventScoresOutputTable";
            this.eventScoresOutputTable.Size = new System.Drawing.Size(500, 269);
            this.eventScoresOutputTable.TabIndex = 0;
            this.eventScoresOutputTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventScoresOutputTable_CellValueChanged);
            // 
            // totalsOutputTab
            // 
            this.totalsOutputTab.Controls.Add(this.sortByDescendingButton);
            this.totalsOutputTab.Controls.Add(this.sortByAscendingButton);
            this.totalsOutputTab.Controls.Add(this.totalScoresOutputTable);
            this.totalsOutputTab.Location = new System.Drawing.Point(4, 22);
            this.totalsOutputTab.Name = "totalsOutputTab";
            this.totalsOutputTab.Padding = new System.Windows.Forms.Padding(3);
            this.totalsOutputTab.Size = new System.Drawing.Size(507, 276);
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
            this.totalScoresOutputTable.Size = new System.Drawing.Size(495, 235);
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
            this.event1ScoreColumn.HeaderText = "Archery";
            this.event1ScoreColumn.Name = "event1ScoreColumn";
            // 
            // event2ScoreColumn
            // 
            this.event2ScoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event2ScoreColumn.HeaderText = "Chess";
            this.event2ScoreColumn.Name = "event2ScoreColumn";
            // 
            // event3ScoreColumn
            // 
            this.event3ScoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event3ScoreColumn.HeaderText = "Checkers";
            this.event3ScoreColumn.Name = "event3ScoreColumn";
            // 
            // event4ScoreColumn
            // 
            this.event4ScoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event4ScoreColumn.HeaderText = "Cycling";
            this.event4ScoreColumn.Name = "event4ScoreColumn";
            // 
            // event5ScoreColumn
            // 
            this.event5ScoreColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event5ScoreColumn.HeaderText = "800m";
            this.event5ScoreColumn.Name = "event5ScoreColumn";
            // 
            // ScoringProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 359);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.writeToFileButton);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScoringProgram";
            this.Text = "iScores";
            this.tabControl.ResumeLayout(false);
            this.inputTab.ResumeLayout(false);
            this.inputTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankInputNumericUpDown)).EndInit();
            this.eventOutputTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventScoresOutputTable)).EndInit();
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
        private System.Windows.Forms.TabPage eventOutputTab;
        public System.Windows.Forms.DataGridView totalScoresOutputTable;
        public System.Windows.Forms.DataGridView eventScoresOutputTable;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.NumericUpDown rankInputNumericUpDown;
        private System.Windows.Forms.ComboBox nameInputComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestantNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event1ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event2ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event3ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event4ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event5ScoreColumn;
    }
}

