namespace Group_Spotify_Architect
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
            this.lb_connected = new System.Windows.Forms.Label();
            this.lb_country = new System.Windows.Forms.Label();
            this.lb_spotify = new System.Windows.Forms.ListBox();
            this.lb_Catagory = new System.Windows.Forms.Label();
            this.bt_searchPlaylist = new System.Windows.Forms.Button();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_catagory = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_connected
            // 
            this.lb_connected.AutoSize = true;
            this.lb_connected.Location = new System.Drawing.Point(16, 11);
            this.lb_connected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_connected.Name = "lb_connected";
            this.lb_connected.Size = new System.Drawing.Size(102, 17);
            this.lb_connected.TabIndex = 1;
            this.lb_connected.Text = "Not Connected";
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.lb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_country.Location = new System.Drawing.Point(38, 58);
            this.lb_country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(80, 24);
            this.lb_country.TabIndex = 4;
            this.lb_country.Text = "Country:";
            // 
            // lb_spotify
            // 
            this.lb_spotify.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_spotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_spotify.FormattingEnabled = true;
            this.lb_spotify.ItemHeight = 22;
            this.lb_spotify.Location = new System.Drawing.Point(3, 209);
            this.lb_spotify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_spotify.Name = "lb_spotify";
            this.lb_spotify.Size = new System.Drawing.Size(514, 268);
            this.lb_spotify.TabIndex = 7;
            // 
            // lb_Catagory
            // 
            this.lb_Catagory.AutoSize = true;
            this.lb_Catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_Catagory.Location = new System.Drawing.Point(250, 58);
            this.lb_Catagory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Catagory.Name = "lb_Catagory";
            this.lb_Catagory.Size = new System.Drawing.Size(89, 24);
            this.lb_Catagory.TabIndex = 8;
            this.lb_Catagory.Text = "Catagory:";
            // 
            // bt_searchPlaylist
            // 
            this.bt_searchPlaylist.BackColor = System.Drawing.Color.Plum;
            this.bt_searchPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_searchPlaylist.Location = new System.Drawing.Point(174, 142);
            this.bt_searchPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_searchPlaylist.Name = "bt_searchPlaylist";
            this.bt_searchPlaylist.Size = new System.Drawing.Size(135, 28);
            this.bt_searchPlaylist.TabIndex = 10;
            this.bt_searchPlaylist.Text = "Search Playlist";
            this.bt_searchPlaylist.UseVisualStyleBackColor = false;
            this.bt_searchPlaylist.Click += new System.EventHandler(this.Bt_searchPlaylist_Click);
            // 
            // cb_country
            // 
            this.cb_country.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(19, 92);
            this.cb_country.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(160, 30);
            this.cb_country.TabIndex = 11;
            // 
            // cb_catagory
            // 
            this.cb_catagory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_catagory.FormattingEnabled = true;
            this.cb_catagory.Location = new System.Drawing.Point(214, 92);
            this.cb_catagory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_catagory.Name = "cb_catagory";
            this.cb_catagory.Size = new System.Drawing.Size(160, 30);
            this.cb_catagory.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericUpDown1.Location = new System.Drawing.Point(417, 93);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 28);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(391, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Song Amount";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Plum;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PlayButton.Location = new System.Drawing.Point(192, 493);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(100, 39);
            this.PlayButton.TabIndex = 15;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Song Playlist:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(560, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cb_catagory);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.bt_searchPlaylist);
            this.Controls.Add(this.lb_Catagory);
            this.Controls.Add(this.lb_spotify);
            this.Controls.Add(this.lb_country);
            this.Controls.Add(this.lb_connected);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_connected;
        private System.Windows.Forms.Label lb_country;
        private System.Windows.Forms.ListBox lb_spotify;
        private System.Windows.Forms.Label lb_Catagory;
        private System.Windows.Forms.Button bt_searchPlaylist;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.ComboBox cb_catagory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label2;
    }
}

