using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshrp_CV04
{
    public partial class Form1 : Form
    {
        public Random Random { get; set; } = new Random();
        public Stats Stats { get; set; } = new Stats();

        public Form1()
        {
            Stats.UpdatedStats += new Stats.UpdatedStatsEvenHandler(UpdateHandler);            
            InitializeComponent();
        }

        private void UpdateHandler(object sender, EventArgs e)
        {
            correctLabel.Text = $"Correct: {Stats.Correct}";
            missedLabel.Text = $"Missed: {Stats.Missed}";
            accurancyLabel.Text = $"Accurancy: {Stats.Accuracy}%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameListBox.Items.Add((Keys)Random.Next('A', 'Z'));

            if (gameListBox.Items.Count >= 6)
            {
                timer1.Stop();

                gameListBox.Items.Clear();

                gameListBox.Items.Add("GAME OVER!");
            }
        }

        private void gameListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameListBox.Items.Contains(e.KeyCode))
            {
                gameListBox.Items.Remove(e.KeyCode);
                gameListBox.Refresh();

                if (timer1.Interval > 450) timer1.Interval -= 80;
                else if (timer1.Interval > 250) timer1.Interval -= 15;
                else if (timer1.Interval > 150) timer1.Interval -= 8;
                else throw new Exception();

                Stats.Update(true);

            }
            else 
            {
                Stats.Update(false);
            }

            if (timer1.Interval > 0 && timer1.Interval < 800) difficultProgressBar.Value = 800 - timer1.Interval;
            else difficultProgressBar.Value = 0;

        }
    }
}
