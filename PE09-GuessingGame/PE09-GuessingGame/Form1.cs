using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Samar Karnani
 * Prof E Cascioli
 * 11/02/20
 * PE10 Guessing game multi windowed
 * For ease of grading i have added a console.writeline for every random generated so you know what the number is
 */

namespace PE09_GuessingGame
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        private int number;
        private int low;
        private int high;

        public Form1(int low, int high, int time)
        {
            InitializeComponent();
            number = rng.Next(low,high+1);
            Visible = false;
            progressBar1.Maximum = time;
            timer1.Start();
            Console.WriteLine(number);
            this.low = low;
            this.high = high;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = int.TryParse(textBox1.Text.Trim(), out int guess);

            if(valid)
            {
                if(guess == number)
                {
                    textBox2.Text = "Correct!";
                    StopGame();
                }
                else if(guess > number)
                {
                    textBox2.Text = "Too high!";
                }
                else if(guess< number)
                {
                    textBox2.Text = "Too low!";
                }
            }
            else
            {
                textBox2.Text = $"Invalid Input! Please enter a number from {low} to {high}";
            }
        }

        /// <summary>
        /// Stops the game when the user gets the guess correct.
        /// </summary>
        private void StopGame()
        {
            textBox1.ReadOnly = true;
            label5.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            timer1.Stop();
        }

        /// <summary>
        /// Resets the game when the reset button is clicked
        /// it is hooked on to the click event of the reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resetgame(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
            label5.Visible = true;
            textBox1.ReadOnly = false;
            number = rng.Next(low,high+1);
            timer1.Start();
            progressBar1.Value = 0;

            textBox1.Text = "";
            textBox2.Text = "";
            groupBox1.Visible = false;
            Console.WriteLine(number);
        }

        /// <summary>
        /// fills the progress bar every second 
        /// if the progress bar is full it stops the game and closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                StopGame();
                MessageBox.Show("You have run out of time!", "ERROR", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
