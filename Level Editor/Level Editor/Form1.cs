using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Editor
{
    public partial class Form1 : Form
    {
        LevelEditor lvl;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Is called when the CreateMapButton is clicked.
        /// creates a map using the validated user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateMapButton_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                lvl = new LevelEditor(int.Parse(WidthTextbox.Text), int.Parse(HeightTextbox.Text));
                lvl.ShowDialog();
            }
        }

        /// <summary>
        /// Validates the user input when the create map button is pressed
        /// returns if the input is valid or not
        /// </summary>
        /// <returns> if user input is valid </returns>
        private bool Validation()
        {
            bool success = true;
            int width = 10;
            int height = 10;
            string errors = "";

            //for width
            if (!int.TryParse(WidthTextbox.Text, out width) || width > 30 || width < 10)
            {
                success = false;
                errors += "Width: Please enter a value between 10 and 30!\n";
            }

            //for height
            if (!int.TryParse(HeightTextbox.Text, out height) || height > 30 || height < 10)
            {
                success = false;
                errors += "Height: Please enter a value between 10 and 30!\n";
            }

            if (success)
            {
                return true;
            }

            MessageBox.Show(errors, "Error!", MessageBoxButtons.OK);
            return false;
        }

        /// <summary>
        /// Is used when the loadmap button is pressed
        /// Opens a level editor with a default constructor which then loads in the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadmapButton_Click(object sender, EventArgs e)
        {
            lvl = new LevelEditor();
            if (!lvl.IsDisposed)
            {
                lvl.ShowDialog();
            }
        }
    }
}
