using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGame_uni
{
    public partial class Form1 : Form
    {
        int randomNumber;
        int TryCount = 0;
        int Time = 0;
        string playerName;
        public Form1()
        {
            InitializeComponent();
            txtGuess.Enabled = false;
            btnCheck.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!txtPlayer.Text.All(char.IsLetter))
            {
                MessageBox.Show("Name must include characters!");
                return;
            }
           

                playerName = txtPlayer.Text;

            Random rnd = new Random();
            randomNumber = rnd.Next(1, 101);

            TryCount = 0;
            Time = 0;

            lblTry.Text = "Tries:0";
            lblTime.Text = "Time: 0";

            txtGuess.Enabled = true;
            btnCheck.Enabled = true;

            timer1.Start();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int Guess;
            if (!int.TryParse(txtGuess.Text, out Guess))
            {
                MessageBox.Show("Enter the number please");
                return;
            }

            TryCount++;
            lblTry.Text = "Tries: " + TryCount;
            if (Guess > randomNumber)
            {
                lblResult.Text = "the number is greater than the default!";
                lblResult.ForeColor = Color.Red;
            }
            else if (Guess < randomNumber)
            {
                lblResult.Text = " the number is lesser than the default!";
                lblResult.ForeColor = Color.Red;
            }
            else
            {
                lblResult.ForeColor = Color.Green;
                timer1.Stop();
                int score = CalculateScore();
                SaveToFile(playerName, score, Time);
                MessageBox.Show($"Congratulations{playerName}!\n Score:{score}\n Time:{Time}");

                btnCheck.Enabled = false;
                txtGuess.Enabled = false;

            }
            txtGuess.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time++;
            lblTime.Text = "The time is: " + Time;
        }
        int CalculateScore()
        {
            if (TryCount < 5)
                return 40;
            else if (TryCount <= 10)
                return 20;
            else
                return 10;

        }
        void SaveToFile(string player, int score, int time)
        {
            try
            {
                string folderPath = @"C:\202";
                string filePath = @"C:\202\Num.txt";

                // ساخت پوشه (اگر وجود نداشته باشد)
                Directory.CreateDirectory(folderPath);

                string text =
                    $"Player: {player} | Score: {score} | Time: {time} Sec | {DateTime.Now}\n";

                File.AppendAllText(filePath, text);

                MessageBox.Show("Information saved ✅");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}