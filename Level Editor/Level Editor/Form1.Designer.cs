namespace Level_Editor
{
    partial class Form1
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
            this.LoadmapButton = new System.Windows.Forms.Button();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthTextbox = new System.Windows.Forms.TextBox();
            this.HeightTextbox = new System.Windows.Forms.TextBox();
            this.CreateMapButton = new System.Windows.Forms.Button();
            this.NewMapGroupbox = new System.Windows.Forms.GroupBox();
            this.NewMapGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadmapButton
            // 
            this.LoadmapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoadmapButton.Location = new System.Drawing.Point(51, 27);
            this.LoadmapButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadmapButton.Name = "LoadmapButton";
            this.LoadmapButton.Size = new System.Drawing.Size(241, 71);
            this.LoadmapButton.TabIndex = 0;
            this.LoadmapButton.Text = "Load Map";
            this.LoadmapButton.UseVisualStyleBackColor = true;
            this.LoadmapButton.Click += new System.EventHandler(this.LoadmapButton_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WidthLabel.Location = new System.Drawing.Point(24, 27);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(171, 29);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width (in tiles):";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HeightLabel.Location = new System.Drawing.Point(24, 89);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(180, 29);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height (in tiles):";
            // 
            // WidthTextbox
            // 
            this.WidthTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WidthTextbox.Location = new System.Drawing.Point(157, 25);
            this.WidthTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthTextbox.Name = "WidthTextbox";
            this.WidthTextbox.Size = new System.Drawing.Size(88, 35);
            this.WidthTextbox.TabIndex = 3;
            // 
            // HeightTextbox
            // 
            this.HeightTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HeightTextbox.Location = new System.Drawing.Point(157, 87);
            this.HeightTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HeightTextbox.Name = "HeightTextbox";
            this.HeightTextbox.Size = new System.Drawing.Size(88, 35);
            this.HeightTextbox.TabIndex = 4;
            // 
            // CreateMapButton
            // 
            this.CreateMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CreateMapButton.Location = new System.Drawing.Point(27, 135);
            this.CreateMapButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateMapButton.Name = "CreateMapButton";
            this.CreateMapButton.Size = new System.Drawing.Size(241, 71);
            this.CreateMapButton.TabIndex = 5;
            this.CreateMapButton.Text = "Create Map";
            this.CreateMapButton.UseVisualStyleBackColor = true;
            this.CreateMapButton.Click += new System.EventHandler(this.CreateMapButton_Click);
            // 
            // NewMapGroupbox
            // 
            this.NewMapGroupbox.Controls.Add(this.CreateMapButton);
            this.NewMapGroupbox.Controls.Add(this.HeightTextbox);
            this.NewMapGroupbox.Controls.Add(this.WidthTextbox);
            this.NewMapGroupbox.Controls.Add(this.HeightLabel);
            this.NewMapGroupbox.Controls.Add(this.WidthLabel);
            this.NewMapGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NewMapGroupbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewMapGroupbox.Location = new System.Drawing.Point(23, 116);
            this.NewMapGroupbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewMapGroupbox.Name = "NewMapGroupbox";
            this.NewMapGroupbox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewMapGroupbox.Size = new System.Drawing.Size(308, 231);
            this.NewMapGroupbox.TabIndex = 6;
            this.NewMapGroupbox.TabStop = false;
            this.NewMapGroupbox.Text = "Create new map";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 358);
            this.Controls.Add(this.NewMapGroupbox);
            this.Controls.Add(this.LoadmapButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Level Editor";
            this.NewMapGroupbox.ResumeLayout(false);
            this.NewMapGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadmapButton;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WidthTextbox;
        private System.Windows.Forms.TextBox HeightTextbox;
        private System.Windows.Forms.Button CreateMapButton;
        private System.Windows.Forms.GroupBox NewMapGroupbox;
    }
}

