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
    public partial class Parameters : Form
    {
        private int lowNum;
        private int highNum;
        private int time;
        bool valid = true;
        string error;

        public Parameters()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Validation() == true) //checks if input is valid and runs form1
            {
                Form1 form = new Form1(lowNum, highNum, time);
                form.ShowDialog();

            }
            else
            {
                Error();
            }

        }

        /// <summary>
        /// checks if the input from the user is valid and assigns them to local fields
        /// if invalid it adds the error message to the string containing other error messages
        /// </summary>
        /// <returns>if the input is valid or not</returns>
        private bool Validation()
        {
            if(!int.TryParse(this.textBox1.Text, out lowNum))
            {
                valid = false;
                error += "Lowest number is invalid\n";
            }
            if (!int.TryParse(this.textBox2.Text, out highNum))
            {
                valid = false;
                error += "Highest number is invalid\n";
            }
            if (!int.TryParse(this.textBox3.Text, out time))
            {
                valid = false;
                error += "Time is invalid\n";
            }
            if(highNum<lowNum + 10 && highNum>lowNum)
            {
                valid = false;
                error += "Range between highest and lowest numbers must increase\n";
            }
            if(highNum<=lowNum)
            {
                valid = false;
                error += "Highest number must be greater than the lowest number\n";
            }
            if(time == 0)
            {
                valid = false;
                error += "Time cannot be 0";
            }

            return valid;
        }

        /// <summary>
        /// Displays the error messages for invalid input
        /// </summary>
        private void Error()
        {
            MessageBox.Show(error, "ERROR", MessageBoxButtons.OK);
            error = "";
            valid = true;
        }
    }
}
