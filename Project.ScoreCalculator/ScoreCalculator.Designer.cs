namespace ScoreCalculator
{
    partial class frmScoreCalculator
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
            this.ClearScoresButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreTotalLabel = new System.Windows.Forms.Label();
            this.ScoreCountLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.ScoreTotalTextBox = new System.Windows.Forms.TextBox();
            this.ScoreCountTextBox = new System.Windows.Forms.TextBox();
            this.ScoreAverageTextBox = new System.Windows.Forms.TextBox();
            this.DisplayScoresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearScoresButton
            // 
            this.ClearScoresButton.Location = new System.Drawing.Point(161, 202);
            this.ClearScoresButton.Name = "ClearScoresButton";
            this.ClearScoresButton.Size = new System.Drawing.Size(75, 23);
            this.ClearScoresButton.TabIndex = 0;
            this.ClearScoresButton.Text = "Clear Scores";
            this.ClearScoresButton.UseVisualStyleBackColor = true;
            this.ClearScoresButton.Click += new System.EventHandler(this.ClearScoresButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(161, 252);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(255, 38);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(40, 38);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(38, 13);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "Score:";
            // 
            // ScoreTotalLabel
            // 
            this.ScoreTotalLabel.AutoSize = true;
            this.ScoreTotalLabel.Location = new System.Drawing.Point(40, 82);
            this.ScoreTotalLabel.Name = "ScoreTotalLabel";
            this.ScoreTotalLabel.Size = new System.Drawing.Size(65, 13);
            this.ScoreTotalLabel.TabIndex = 4;
            this.ScoreTotalLabel.Text = "Score Total:";
            // 
            // ScoreCountLabel
            // 
            this.ScoreCountLabel.AutoSize = true;
            this.ScoreCountLabel.Location = new System.Drawing.Point(40, 122);
            this.ScoreCountLabel.Name = "ScoreCountLabel";
            this.ScoreCountLabel.Size = new System.Drawing.Size(69, 13);
            this.ScoreCountLabel.TabIndex = 5;
            this.ScoreCountLabel.Text = "Score Count:";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(40, 161);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(50, 13);
            this.AverageLabel.TabIndex = 6;
            this.AverageLabel.Text = "Average:";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(136, 35);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.ScoreTextBox.TabIndex = 7;
            // 
            // ScoreTotalTextBox
            // 
            this.ScoreTotalTextBox.Location = new System.Drawing.Point(136, 75);
            this.ScoreTotalTextBox.Name = "ScoreTotalTextBox";
            this.ScoreTotalTextBox.ReadOnly = true;
            this.ScoreTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.ScoreTotalTextBox.TabIndex = 8;
            // 
            // ScoreCountTextBox
            // 
            this.ScoreCountTextBox.Location = new System.Drawing.Point(136, 115);
            this.ScoreCountTextBox.Name = "ScoreCountTextBox";
            this.ScoreCountTextBox.ReadOnly = true;
            this.ScoreCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.ScoreCountTextBox.TabIndex = 9;
            // 
            // ScoreAverageTextBox
            // 
            this.ScoreAverageTextBox.Location = new System.Drawing.Point(136, 153);
            this.ScoreAverageTextBox.Name = "ScoreAverageTextBox";
            this.ScoreAverageTextBox.ReadOnly = true;
            this.ScoreAverageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ScoreAverageTextBox.TabIndex = 10;
            // 
            // DisplayScoresButton
            // 
            this.DisplayScoresButton.Location = new System.Drawing.Point(43, 201);
            this.DisplayScoresButton.Name = "DisplayScoresButton";
            this.DisplayScoresButton.Size = new System.Drawing.Size(99, 23);
            this.DisplayScoresButton.TabIndex = 11;
            this.DisplayScoresButton.Text = "Display Scores";
            this.DisplayScoresButton.UseVisualStyleBackColor = true;
            this.DisplayScoresButton.Click += new System.EventHandler(this.DisplayScoresButton_Click);
            // 
            // frmScoreCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(358, 287);
            this.Controls.Add(this.DisplayScoresButton);
            this.Controls.Add(this.ScoreAverageTextBox);
            this.Controls.Add(this.ScoreCountTextBox);
            this.Controls.Add(this.ScoreTotalTextBox);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.ScoreCountLabel);
            this.Controls.Add(this.ScoreTotalLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearScoresButton);
            this.Name = "frmScoreCalculator";
            this.Text = "ScoreCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearScoresButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreTotalLabel;
        private System.Windows.Forms.Label ScoreCountLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.TextBox ScoreTotalTextBox;
        private System.Windows.Forms.TextBox ScoreCountTextBox;
        private System.Windows.Forms.TextBox ScoreAverageTextBox;
        private System.Windows.Forms.Button DisplayScoresButton;
    }
}

