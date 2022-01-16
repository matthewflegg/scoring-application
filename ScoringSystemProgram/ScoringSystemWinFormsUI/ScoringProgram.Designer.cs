﻿
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.writeToFileButton = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.eventInputLabel = new System.Windows.Forms.Label();
            this.rankInputLabel = new System.Windows.Forms.Label();
            this.enterInputButton = new System.Windows.Forms.Button();
            this.nameInputTextBox = new System.Windows.Forms.TextBox();
            this.rankInputTextBox = new System.Windows.Forms.TextBox();
            this.eventInputComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 45);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(649, 299);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.eventInputComboBox);
            this.tabPage1.Controls.Add(this.rankInputTextBox);
            this.tabPage1.Controls.Add(this.nameInputTextBox);
            this.tabPage1.Controls.Add(this.enterInputButton);
            this.tabPage1.Controls.Add(this.rankInputLabel);
            this.tabPage1.Controls.Add(this.eventInputLabel);
            this.tabPage1.Controls.Add(this.nameInputLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enter Contestant Results";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Total Scores";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // nameInputLabel
            // 
            this.nameInputLabel.AutoSize = true;
            this.nameInputLabel.Location = new System.Drawing.Point(29, 32);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(63, 13);
            this.nameInputLabel.TabIndex = 0;
            this.nameInputLabel.Text = "Enter Name";
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
            // rankInputLabel
            // 
            this.rankInputLabel.AutoSize = true;
            this.rankInputLabel.Location = new System.Drawing.Point(29, 85);
            this.rankInputLabel.Name = "rankInputLabel";
            this.rankInputLabel.Size = new System.Drawing.Size(61, 13);
            this.rankInputLabel.TabIndex = 2;
            this.rankInputLabel.Text = "Enter Rank";
            // 
            // enterInputButton
            // 
            this.enterInputButton.Location = new System.Drawing.Point(128, 108);
            this.enterInputButton.Name = "enterInputButton";
            this.enterInputButton.Size = new System.Drawing.Size(75, 23);
            this.enterInputButton.TabIndex = 3;
            this.enterInputButton.Text = "Enter";
            this.enterInputButton.UseVisualStyleBackColor = true;
            // 
            // nameInputTextBox
            // 
            this.nameInputTextBox.Location = new System.Drawing.Point(128, 29);
            this.nameInputTextBox.Name = "nameInputTextBox";
            this.nameInputTextBox.Size = new System.Drawing.Size(139, 20);
            this.nameInputTextBox.TabIndex = 4;
            // 
            // rankInputTextBox
            // 
            this.rankInputTextBox.Location = new System.Drawing.Point(128, 82);
            this.rankInputTextBox.Name = "rankInputTextBox";
            this.rankInputTextBox.Size = new System.Drawing.Size(139, 20);
            this.rankInputTextBox.TabIndex = 5;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button writeToFileButton;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Label rankInputLabel;
        private System.Windows.Forms.Label eventInputLabel;
        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Button enterInputButton;
        private System.Windows.Forms.ComboBox eventInputComboBox;
        private System.Windows.Forms.TextBox rankInputTextBox;
        private System.Windows.Forms.TextBox nameInputTextBox;
    }
}
