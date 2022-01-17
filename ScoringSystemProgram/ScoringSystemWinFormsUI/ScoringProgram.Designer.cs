
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inputTab = new System.Windows.Forms.TabPage();
            this.eventInputComboBox = new System.Windows.Forms.ComboBox();
            this.rankInputTextBox = new System.Windows.Forms.TextBox();
            this.nameInputTextBox = new System.Windows.Forms.TextBox();
            this.enterInputButton = new System.Windows.Forms.Button();
            this.rankInputLabel = new System.Windows.Forms.Label();
            this.eventInputLabel = new System.Windows.Forms.Label();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.outputTab = new System.Windows.Forms.TabPage();
            this.outputTable = new System.Windows.Forms.DataGridView();
            this.writeToFileButton = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.contestantNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalScoreTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.inputTab.SuspendLayout();
            this.outputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.inputTab);
            this.tabControl.Controls.Add(this.outputTab);
            this.tabControl.Location = new System.Drawing.Point(12, 45);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(649, 299);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // inputTab
            // 
            this.inputTab.Controls.Add(this.eventInputComboBox);
            this.inputTab.Controls.Add(this.rankInputTextBox);
            this.inputTab.Controls.Add(this.nameInputTextBox);
            this.inputTab.Controls.Add(this.enterInputButton);
            this.inputTab.Controls.Add(this.rankInputLabel);
            this.inputTab.Controls.Add(this.eventInputLabel);
            this.inputTab.Controls.Add(this.nameInputLabel);
            this.inputTab.Location = new System.Drawing.Point(4, 22);
            this.inputTab.Name = "inputTab";
            this.inputTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputTab.Size = new System.Drawing.Size(641, 273);
            this.inputTab.TabIndex = 0;
            this.inputTab.Text = "Enter Contestant Results";
            this.inputTab.UseVisualStyleBackColor = true;
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
            // rankInputTextBox
            // 
            this.rankInputTextBox.Location = new System.Drawing.Point(128, 82);
            this.rankInputTextBox.Name = "rankInputTextBox";
            this.rankInputTextBox.Size = new System.Drawing.Size(139, 20);
            this.rankInputTextBox.TabIndex = 5;
            // 
            // nameInputTextBox
            // 
            this.nameInputTextBox.Location = new System.Drawing.Point(128, 29);
            this.nameInputTextBox.Name = "nameInputTextBox";
            this.nameInputTextBox.Size = new System.Drawing.Size(139, 20);
            this.nameInputTextBox.TabIndex = 4;
            // 
            // enterInputButton
            // 
            this.enterInputButton.Location = new System.Drawing.Point(128, 108);
            this.enterInputButton.Name = "enterInputButton";
            this.enterInputButton.Size = new System.Drawing.Size(75, 23);
            this.enterInputButton.TabIndex = 3;
            this.enterInputButton.Text = "Enter";
            this.enterInputButton.UseVisualStyleBackColor = true;
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
            // outputTab
            // 
            this.outputTab.Controls.Add(this.outputTable);
            this.outputTab.Location = new System.Drawing.Point(4, 22);
            this.outputTab.Name = "outputTab";
            this.outputTab.Padding = new System.Windows.Forms.Padding(3);
            this.outputTab.Size = new System.Drawing.Size(641, 273);
            this.outputTab.TabIndex = 1;
            this.outputTab.Text = "View Total Scores";
            this.outputTab.UseVisualStyleBackColor = true;
            // 
            // outputTable
            // 
            this.outputTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contestantNameTextBoxColumn,
            this.totalScoreTextBoxColumn});
            this.outputTable.Location = new System.Drawing.Point(6, 6);
            this.outputTable.Name = "outputTable";
            this.outputTable.Size = new System.Drawing.Size(632, 261);
            this.outputTable.TabIndex = 0;
            // 
            // writeToFileButton
            // 
            this.writeToFileButton.Location = new System.Drawing.Point(12, 12);
            this.writeToFileButton.Name = "writeToFileButton";
            this.writeToFileButton.Size = new System.Drawing.Size(75, 23);
            this.writeToFileButton.TabIndex = 1;
            this.writeToFileButton.Text = "Write to File";
            this.writeToFileButton.UseVisualStyleBackColor = true;
            // 
            // clearDataButton
            // 
            this.clearDataButton.Location = new System.Drawing.Point(93, 12);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(75, 23);
            this.clearDataButton.TabIndex = 2;
            this.clearDataButton.Text = "Clear Data";
            this.clearDataButton.UseVisualStyleBackColor = true;
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
            // ScoringProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 356);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.writeToFileButton);
            this.Controls.Add(this.tabControl);
            this.Name = "ScoringProgram";
            this.Text = "Scoring System Program";
            this.tabControl.ResumeLayout(false);
            this.inputTab.ResumeLayout(false);
            this.inputTab.PerformLayout();
            this.outputTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inputTab;
        private System.Windows.Forms.TabPage outputTab;
        private System.Windows.Forms.Button writeToFileButton;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Label rankInputLabel;
        private System.Windows.Forms.Label eventInputLabel;
        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Button enterInputButton;
        private System.Windows.Forms.ComboBox eventInputComboBox;
        private System.Windows.Forms.TextBox rankInputTextBox;
        private System.Windows.Forms.TextBox nameInputTextBox;
        private System.Windows.Forms.DataGridView outputTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestantNameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalScoreTextBoxColumn;
    }
}

