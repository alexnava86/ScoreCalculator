using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class frmScoreCalculator : Form
    {
        private int scoreTotal = 0;
        private int scoreCount = 0;
        private int[] scores = new int[20];

        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            scores[scoreCount] = Convert.ToInt32(ScoreTextBox.Text);
            scoreTotal += Convert.ToInt32(ScoreTextBox.Text);
            scoreCount++;
            int scoreAvg = scoreTotal/scoreCount;
            ScoreTotalTextBox.Text = scoreTotal.ToString();
            ScoreCountTextBox.Text = scoreCount.ToString();
            ScoreAverageTextBox.Text = scoreAvg.ToString();
            ScoreTextBox.Focus();
        }
        private void ClearScoresButton_Click(object sender, EventArgs e)
        {
            scores = new int[20];
            scoreTotal = 0;
            scoreCount = 0;
            ScoreTotalTextBox.Text = scoreTotal.ToString();
            ScoreCountTextBox.Text = scoreCount.ToString();
            ScoreTextBox.Text = "0";
            ScoreAverageTextBox.Text = "0";
            ScoreTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayScoresButton_Click(object sender, EventArgs e)
        {
            Form scoresForm = new frmScores();
            DialogResult tb = scoresForm.ShowDialog();
            Array.Sort(scores);
            
        }
    }
}
