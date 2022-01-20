
namespace ScoringSystemWinFormsUI
{
    partial class WriteToFilePopup
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
            this.labelPrompt = new System.Windows.Forms.Label();
            this.textboxFilePath = new System.Windows.Forms.TextBox();
            this.buttonEnterFilePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(13, 13);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(84, 13);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "Enter a file path:";
            // 
            // textboxFilePath
            // 
            this.textboxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxFilePath.Location = new System.Drawing.Point(103, 10);
            this.textboxFilePath.Name = "textboxFilePath";
            this.textboxFilePath.Size = new System.Drawing.Size(190, 20);
            this.textboxFilePath.TabIndex = 1;
            // 
            // buttonEnterFilePath
            // 
            this.buttonEnterFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnterFilePath.Location = new System.Drawing.Point(103, 36);
            this.buttonEnterFilePath.Name = "buttonEnterFilePath";
            this.buttonEnterFilePath.Size = new System.Drawing.Size(92, 23);
            this.buttonEnterFilePath.TabIndex = 2;
            this.buttonEnterFilePath.Text = "Write to File";
            this.buttonEnterFilePath.UseVisualStyleBackColor = true;
            this.buttonEnterFilePath.Click += new System.EventHandler(this.buttonEnterFilePath_Click);
            // 
            // WriteToFilePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 68);
            this.Controls.Add(this.buttonEnterFilePath);
            this.Controls.Add(this.textboxFilePath);
            this.Controls.Add(this.labelPrompt);
            this.Name = "WriteToFilePopup";
            this.Text = "Enter a Path";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button buttonEnterFilePath;
        public System.Windows.Forms.TextBox textboxFilePath;
    }
}