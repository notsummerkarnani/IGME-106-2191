using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

/* Samar Karnani
 * 10/02/20
 * Prof E. Cascioli
 * PE08_Windows UI
 */

namespace PE08_WindowsUI
{
    class MyForm: Form
    {
        Random rng = new Random(); //used to set button colour
        public MyForm()
        {
            this.Size = new Size(1050, 1050);
            this.Text = "PE08";

            //Creates a 10x10 grid of buttons with size(100,100) and colour lavender
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(100, 100);
                    button.Location = new Point(100 * i, 100 * j);
                    button.BackColor = Color.Lavender;
                    this.Controls.Add(button);
                    button.MouseEnter += MouseEnter;    //Triggers MouseEnter when the mouse enters a button
                    button.MouseLeave += MouseLeave;    //Triggers MouseLeve when the mouse leaves a button
                }

            }
            
        }

        /// <summary>
        /// Checks if sender is a button
        /// if it is, casts sender to a button and changes its backcolour to a random colour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                ((Button)sender).BackColor = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));
            }
        }

        /// <summary>
        /// Checks if sender is a button
        /// if it is, casts sender to a button and changes its backcolour to lavender blush 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                ((Button)sender).BackColor = Color.LavenderBlush;
            }
        }
    }
}
