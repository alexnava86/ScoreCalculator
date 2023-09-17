namespace ScoreCalculator
{
    partial class frmScores
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
            this.ScoresRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoresRichTextBox
            // 
            this.ScoresRichTextBox.Location = new System.Drawing.Point(-7, -16);
            this.ScoresRichTextBox.Name = "ScoresRichTextBox";
            this.ScoresRichTextBox.Size = new System.Drawing.Size(302, 201);
            this.ScoresRichTextBox.TabIndex = 0;
            this.ScoresRichTextBox.Text = "";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(105, 213);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // frmScores
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OkButton;
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ScoresRichTextBox);
            this.Name = "frmScores";
            this.Text = "Scores";
            this.ResumeLayout(false);
            this.Tag = "";
        }
        #endregion

        private System.Windows.Forms.RichTextBox ScoresRichTextBox;
        private System.Windows.Forms.Button OkButton;
    }
}