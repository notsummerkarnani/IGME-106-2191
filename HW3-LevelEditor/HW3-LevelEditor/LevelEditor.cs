using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/* Samar Karnani
 * Homework 3 - Level Editor
 * 01/03/20
 * Prof E. Cascioli
 */

namespace HW3_LevelEditor
{
    public partial class LevelEditor : Form
    {
        private int lvlwidth;       //Holds the width of the map(in pictureboxes)
        private int lvlheight;      //Holds the width of the map(in pictureboxes)
        private PictureBox[,] grid;     //Holds the grid of pictureboxes that make up the map
        PictureBox[] palette = new PictureBox[10];  //holds the pictureboxes in the palette
        PictureBox selectedColour;      //holds the selected picturebox (for colour)
        PictureBox selectedColourBckgrnd = new PictureBox();    //highlights the background of a selected colour in the palette
        

        public LevelEditor(int width, int height)
        {
            InitializeComponent();

            MapPicturebox.Visible = false;
            lvlwidth = width;
            lvlheight = height;

            //sets the size of the picturebox containing the grid
            MapPicturebox.Size = new Size(lvlwidth * MapPicturebox.Height/lvlheight, MapPicturebox.Height);
            this.Width = MapPicturebox.Width + 400;
            grid = new PictureBox[lvlheight, lvlwidth];

            //Adds pictureboxes to the grid
            //sets the size, location and colour of the tile
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    PictureBox tile = new PictureBox();
                    tile.Click += ChangeColour;
                    tile.BackColor = Color.Lavender;
                    tile.Size = new Size(MapPicturebox.Width/width,MapPicturebox.Height/height);
                    tile.Location = new Point(MapPicturebox.Location.X + column * tile.Width, MapPicturebox.Location.Y + row * tile.Height);
                    grid[row, column] = tile;
                    this.Controls.Add(grid[row,column]);
                }
            }
        }

        /// <summary>
        /// Default constructor called when LoadFile button is pressed in the main form
        /// </summary>
        public LevelEditor()
        {
            InitializeComponent();
            LoadFileButton_Click(new object(), EventArgs.Empty); //Loads in a file
        }


        /// <summary>
        /// Changes the preview colour when any of the 3 (RGB) colour values are changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePreviewColour(object sender, EventArgs e)
        {
            PreviewColorPicturebox.BackColor = Color.FromArgb((int)ColorRed.Value, (int)ColorGreen.Value, (int)ColorBlue.Value);
        }

        int paletteCount = 0;   //used to keep track of which colour in the palette should be replaced
        /// <summary>
        /// Called when the Add to Paletter button is clicked
        /// Changes the colour of the picturebox in the palette to that of the previewpicturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToPaletteButton_Click(object sender, EventArgs e)
        {
            PaletteGroupbox.Controls[paletteCount % 10].BackColor = PreviewColorPicturebox.BackColor;
            paletteCount++;
        }

        /// <summary>
        /// Is called when any of the pictureboxes in the palette are selected
        /// Creates a new picturebox behind the selcted one to highlight it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectColour(object sender, EventArgs e)
        {
            if(sender is PictureBox)
            {
                selectedColour = ((PictureBox)sender);
                PaletteGroupbox.Controls.Add(selectedColourBckgrnd);
                selectedColourBckgrnd.BackColor = ((PictureBox)sender).BackColor;
                selectedColourBckgrnd.Size = new Size(((PictureBox)sender).Width +6 , ((PictureBox)sender).Height + 6);
                selectedColourBckgrnd.Location = new Point(((PictureBox)sender).Location.X - 3, ((PictureBox)sender).Location.Y-3);
            }
        }

        /// <summary>
        /// Is called when a picturebox in the map is clicked
        /// If a colour in the palette is selected it will change the picturebox in the map's colour to that one
        /// It also changes the text of the form to keep track of whether a change has been made or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeColour(object sender, EventArgs e)
        {
            if(sender is PictureBox && selectedColour != null)
            {
                ((PictureBox)sender).BackColor = selectedColour.BackColor;
                if (this.Text == "Level Editor")
                {
                    this.Text += " *";
                }
            }
        }

        /// <summary>
        /// Is called when the save file button is clicked
        /// Converts the grid to a text file containing the colours of each picturebox
        /// opens a SaveFileDialog to get the information needed to save
        /// Changes the text of the form so that the user can tell that there are no unsaved changes
        /// opens a messagebox showing a confirmation save message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            string fileName;
            string[] lines = new string[grid.GetLength(0)];
            for (int i = 0; i < lines.Length;i++)
            {
                for(int j = 0; j< grid.GetLength(1); j++)
                {
                    lines[i] += grid[i, j].BackColor.ToArgb().ToString() + "|";
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save a Level File";
            saveFileDialog.Filter = "LevelFiles|*.level";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                File.WriteAllLines(fileName, lines);
            }

            this.Text = "Level Editor";
            MessageBox.Show("File saved successfully", "File Saved", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Is called when the Load file button is clicked
        /// Converts the text file to a 2D array of integer values holding the colours of the pictureboxes
        /// opens an openFileDialog to get the information needed to load
        /// opens a messagebox showing a confirmation load message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            string[] text;
            string[,] colourGrid;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open a Level File";
            openFileDialog.Filter = "LevelFiles|*.level";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                text = File.ReadAllLines(openFileDialog.FileName);
                colourGrid = new string[text.Length, text[0].Split('|').Length - 1];
                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0; j < text[0].Split('|').Length - 1; j++)
                    {
                        colourGrid[i, j] = text[i].Split('|')[j];
                        Console.WriteLine(colourGrid[i, j]);
                    }
                }

                MapPicturebox.Visible = false;
                lvlwidth = colourGrid.GetLength(1);
                lvlheight = colourGrid.GetLength(0);

                //sets the size of the picturebox containing the grid
                MapPicturebox.Size = new Size(lvlwidth * MapPicturebox.Height / lvlheight, MapPicturebox.Height);
                this.Width = MapPicturebox.Width + 400;

                //gets rid of any items in the grid if they exist
                if (grid != null)
                {
                    for (int row = 0; row < grid.GetLength(0); row++)
                    {
                        for (int column = 0; column < grid.GetLength(1); column++)
                        {
                            grid[row, column].Dispose();
                        }
                    }
                }
                grid = new PictureBox[lvlheight, lvlwidth];

                //Adds pictureboxes to the grid
                //sets the size, location and colour of the tile
                for (int row = 0; row < lvlheight; row++)
                {
                    for (int column = 0; column < lvlwidth; column++)
                    {

                        PictureBox tile = new PictureBox();
                        tile.Click += ChangeColour;
                        tile.BackColor = Color.FromArgb(int.Parse(colourGrid[row, column]));
                        tile.Size = new Size(MapPicturebox.Width / lvlwidth, MapPicturebox.Height / lvlheight);
                        tile.Location = new Point(MapPicturebox.Location.X + column * tile.Width, MapPicturebox.Location.Y + row * tile.Height);
                        grid[row, column] = tile;
                        this.Controls.Add(grid[row, column]);
                    }
                }

                this.Text = openFileDialog.FileName;
                MessageBox.Show("File loaded successfully", "File Loaded", MessageBoxButtons.OK);
            }
            else if(!(sender is Button))
            {
                this.Close();
            }
        }

        /// <summary>
        /// Checks for unsaved changes if the user wants to close the file
        /// if there are chnages then it prompts the user to save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckForSave(object sender, EventArgs e)
        {
            if(this.Text == "Level Editor")
            {
                return;
            }
            if(MessageBox.Show("There are unsaved changes. Would you like to save them?", "Unsaved Changes!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveFileButton_Click(null, EventArgs.Empty);
            }
        }
    }
}
