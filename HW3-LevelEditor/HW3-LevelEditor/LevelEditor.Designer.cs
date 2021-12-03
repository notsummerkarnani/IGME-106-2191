namespace HW3_LevelEditor
{
    partial class LevelEditor
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
            this.LabelRed = new System.Windows.Forms.Label();
            this.LabelGreen = new System.Windows.Forms.Label();
            this.LabelBlue = new System.Windows.Forms.Label();
            this.ColorRed = new System.Windows.Forms.NumericUpDown();
            this.ColorBlue = new System.Windows.Forms.NumericUpDown();
            this.ColorGreen = new System.Windows.Forms.NumericUpDown();
            this.PreviewColorLabel = new System.Windows.Forms.Label();
            this.PreviewColorPicturebox = new System.Windows.Forms.PictureBox();
            this.ColourPickerGroupbox = new System.Windows.Forms.GroupBox();
            this.AddToPaletteButton = new System.Windows.Forms.Button();
            this.PaletteGroupbox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.MapPicturebox = new System.Windows.Forms.PictureBox();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.LoadFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ColorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewColorPicturebox)).BeginInit();
            this.ColourPickerGroupbox.SuspendLayout();
            this.PaletteGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRed
            // 
            this.LabelRed.AutoSize = true;
            this.LabelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelRed.Location = new System.Drawing.Point(17, 25);
            this.LabelRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelRed.Name = "LabelRed";
            this.LabelRed.Size = new System.Drawing.Size(64, 29);
            this.LabelRed.TabIndex = 1;
            this.LabelRed.Text = "Red:";
            // 
            // LabelGreen
            // 
            this.LabelGreen.AutoSize = true;
            this.LabelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelGreen.Location = new System.Drawing.Point(17, 66);
            this.LabelGreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelGreen.Name = "LabelGreen";
            this.LabelGreen.Size = new System.Drawing.Size(86, 29);
            this.LabelGreen.TabIndex = 2;
            this.LabelGreen.Text = "Green:";
            // 
            // LabelBlue
            // 
            this.LabelBlue.AutoSize = true;
            this.LabelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelBlue.Location = new System.Drawing.Point(17, 109);
            this.LabelBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBlue.Name = "LabelBlue";
            this.LabelBlue.Size = new System.Drawing.Size(68, 29);
            this.LabelBlue.TabIndex = 3;
            this.LabelBlue.Text = "Blue:";
            // 
            // ColorRed
            // 
            this.ColorRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ColorRed.Location = new System.Drawing.Point(95, 23);
            this.ColorRed.Margin = new System.Windows.Forms.Padding(2);
            this.ColorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorRed.Name = "ColorRed";
            this.ColorRed.Size = new System.Drawing.Size(80, 35);
            this.ColorRed.TabIndex = 4;
            this.ColorRed.ValueChanged += new System.EventHandler(this.ChangePreviewColour);
            // 
            // ColorBlue
            // 
            this.ColorBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ColorBlue.Location = new System.Drawing.Point(95, 108);
            this.ColorBlue.Margin = new System.Windows.Forms.Padding(2);
            this.ColorBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorBlue.Name = "ColorBlue";
            this.ColorBlue.Size = new System.Drawing.Size(80, 35);
            this.ColorBlue.TabIndex = 5;
            this.ColorBlue.ValueChanged += new System.EventHandler(this.ChangePreviewColour);
            // 
            // ColorGreen
            // 
            this.ColorGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ColorGreen.Location = new System.Drawing.Point(95, 65);
            this.ColorGreen.Margin = new System.Windows.Forms.Padding(2);
            this.ColorGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorGreen.Name = "ColorGreen";
            this.ColorGreen.Size = new System.Drawing.Size(80, 35);
            this.ColorGreen.TabIndex = 6;
            this.ColorGreen.ValueChanged += new System.EventHandler(this.ChangePreviewColour);
            // 
            // PreviewColorLabel
            // 
            this.PreviewColorLabel.AutoSize = true;
            this.PreviewColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PreviewColorLabel.Location = new System.Drawing.Point(4, 159);
            this.PreviewColorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviewColorLabel.Name = "PreviewColorLabel";
            this.PreviewColorLabel.Size = new System.Drawing.Size(184, 29);
            this.PreviewColorLabel.TabIndex = 7;
            this.PreviewColorLabel.Text = "Preview Colour:";
            // 
            // PreviewColorPicturebox
            // 
            this.PreviewColorPicturebox.BackColor = System.Drawing.Color.Black;
            this.PreviewColorPicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewColorPicturebox.Location = new System.Drawing.Point(145, 151);
            this.PreviewColorPicturebox.Margin = new System.Windows.Forms.Padding(2);
            this.PreviewColorPicturebox.Name = "PreviewColorPicturebox";
            this.PreviewColorPicturebox.Size = new System.Drawing.Size(39, 33);
            this.PreviewColorPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewColorPicturebox.TabIndex = 8;
            this.PreviewColorPicturebox.TabStop = false;
            // 
            // ColourPickerGroupbox
            // 
            this.ColourPickerGroupbox.Controls.Add(this.AddToPaletteButton);
            this.ColourPickerGroupbox.Controls.Add(this.PreviewColorPicturebox);
            this.ColourPickerGroupbox.Controls.Add(this.PreviewColorLabel);
            this.ColourPickerGroupbox.Controls.Add(this.ColorGreen);
            this.ColourPickerGroupbox.Controls.Add(this.ColorBlue);
            this.ColourPickerGroupbox.Controls.Add(this.ColorRed);
            this.ColourPickerGroupbox.Controls.Add(this.LabelBlue);
            this.ColourPickerGroupbox.Controls.Add(this.LabelGreen);
            this.ColourPickerGroupbox.Controls.Add(this.LabelRed);
            this.ColourPickerGroupbox.Location = new System.Drawing.Point(30, 39);
            this.ColourPickerGroupbox.Margin = new System.Windows.Forms.Padding(2);
            this.ColourPickerGroupbox.Name = "ColourPickerGroupbox";
            this.ColourPickerGroupbox.Padding = new System.Windows.Forms.Padding(2);
            this.ColourPickerGroupbox.Size = new System.Drawing.Size(207, 234);
            this.ColourPickerGroupbox.TabIndex = 9;
            this.ColourPickerGroupbox.TabStop = false;
            this.ColourPickerGroupbox.Text = "Colour Picker";
            // 
            // AddToPaletteButton
            // 
            this.AddToPaletteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddToPaletteButton.Location = new System.Drawing.Point(10, 187);
            this.AddToPaletteButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddToPaletteButton.Name = "AddToPaletteButton";
            this.AddToPaletteButton.Size = new System.Drawing.Size(116, 40);
            this.AddToPaletteButton.TabIndex = 9;
            this.AddToPaletteButton.Text = "Add to palette";
            this.AddToPaletteButton.UseVisualStyleBackColor = true;
            this.AddToPaletteButton.Click += new System.EventHandler(this.AddToPaletteButton_Click);
            // 
            // PaletteGroupbox
            // 
            this.PaletteGroupbox.Controls.Add(this.pictureBox1);
            this.PaletteGroupbox.Controls.Add(this.pictureBox2);
            this.PaletteGroupbox.Controls.Add(this.pictureBox3);
            this.PaletteGroupbox.Controls.Add(this.pictureBox4);
            this.PaletteGroupbox.Controls.Add(this.pictureBox5);
            this.PaletteGroupbox.Controls.Add(this.pictureBox10);
            this.PaletteGroupbox.Controls.Add(this.pictureBox9);
            this.PaletteGroupbox.Controls.Add(this.pictureBox8);
            this.PaletteGroupbox.Controls.Add(this.pictureBox7);
            this.PaletteGroupbox.Controls.Add(this.pictureBox6);
            this.PaletteGroupbox.Location = new System.Drawing.Point(27, 283);
            this.PaletteGroupbox.Margin = new System.Windows.Forms.Padding(2);
            this.PaletteGroupbox.Name = "PaletteGroupbox";
            this.PaletteGroupbox.Padding = new System.Windows.Forms.Padding(2);
            this.PaletteGroupbox.Size = new System.Drawing.Size(209, 88);
            this.PaletteGroupbox.TabIndex = 10;
            this.PaletteGroupbox.TabStop = false;
            this.PaletteGroupbox.Text = "Palette";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.SelectColour);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(45, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.SelectColour);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(81, 16);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 30);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.SelectColour);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(116, 16);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 30);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.SelectColour);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(151, 16);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 30);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.SelectColour);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Location = new System.Drawing.Point(10, 49);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 30);
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.SelectColour);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Location = new System.Drawing.Point(45, 49);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 30);
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.SelectColour);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(81, 49);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 30);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.SelectColour);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(116, 49);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 30);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.SelectColour);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(151, 49);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 30);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.SelectColour);
            // 
            // MapPicturebox
            // 
            this.MapPicturebox.Location = new System.Drawing.Point(274, 39);
            this.MapPicturebox.Margin = new System.Windows.Forms.Padding(2);
            this.MapPicturebox.Name = "MapPicturebox";
            this.MapPicturebox.Size = new System.Drawing.Size(400, 390);
            this.MapPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MapPicturebox.TabIndex = 11;
            this.MapPicturebox.TabStop = false;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveFileButton.Location = new System.Drawing.Point(37, 376);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(75, 69);
            this.SaveFileButton.TabIndex = 12;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoadFileButton.Location = new System.Drawing.Point(135, 376);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(75, 69);
            this.LoadFileButton.TabIndex = 13;
            this.LoadFileButton.Text = "Load File";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 478);
            this.Controls.Add(this.LoadFileButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.PaletteGroupbox);
            this.Controls.Add(this.ColourPickerGroupbox);
            this.Controls.Add(this.MapPicturebox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LevelEditor";
            this.Text = "Level Editor";
            this.FormClosing += CheckForSave;
            ((System.ComponentModel.ISupportInitialize)(this.ColorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewColorPicturebox)).EndInit();
            this.ColourPickerGroupbox.ResumeLayout(false);
            this.ColourPickerGroupbox.PerformLayout();
            this.PaletteGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelRed;
        private System.Windows.Forms.Label LabelGreen;
        private System.Windows.Forms.Label LabelBlue;
        private System.Windows.Forms.NumericUpDown ColorRed;
        private System.Windows.Forms.NumericUpDown ColorBlue;
        private System.Windows.Forms.NumericUpDown ColorGreen;
        private System.Windows.Forms.Label PreviewColorLabel;
        private System.Windows.Forms.PictureBox PreviewColorPicturebox;
        private System.Windows.Forms.GroupBox ColourPickerGroupbox;
        private System.Windows.Forms.Button AddToPaletteButton;
        private System.Windows.Forms.GroupBox PaletteGroupbox;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox MapPicturebox;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button LoadFileButton;
    }
}