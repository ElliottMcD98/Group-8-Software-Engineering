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
            this.bt_searchSong = new System.Windows.Forms.Button();
            this.lb_spotify = new System.Windows.Forms.ListBox();
            this.lb_Catagory = new System.Windows.Forms.Label();
            this.bt_searchPlaylist = new System.Windows.Forms.Button();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_catagory = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_connected
            // 
            this.lb_connected.AutoSize = true;
            this.lb_connected.Location = new System.Drawing.Point(24, 17);
            this.lb_connected.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_connected.Name = "lb_connected";
            this.lb_connected.Size = new System.Drawing.Size(155, 25);
            this.lb_connected.TabIndex = 1;
            this.lb_connected.Text = "Not Connected";
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.lb_country.Location = new System.Drawing.Point(30, 165);
            this.lb_country.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(93, 25);
            this.lb_country.TabIndex = 4;
            this.lb_country.Text = "Country:";
            // 
            // bt_searchSong
            // 
            this.bt_searchSong.Location = new System.Drawing.Point(446, 192);
            this.bt_searchSong.Margin = new System.Windows.Forms.Padding(6);
            this.bt_searchSong.Name = "bt_searchSong";
            this.bt_searchSong.Size = new System.Drawing.Size(200, 44);
            this.bt_searchSong.TabIndex = 6;
            this.bt_searchSong.Text = "Search Song";
            this.bt_searchSong.UseVisualStyleBackColor = true;
            this.bt_searchSong.Click += new System.EventHandler(this.bt_searchSong_Click);
            // 
            // lb_spotify
            // 
            this.lb_spotify.FormattingEnabled = true;
            this.lb_spotify.ItemHeight = 25;
            this.lb_spotify.Location = new System.Drawing.Point(1138, 23);
            this.lb_spotify.Margin = new System.Windows.Forms.Padding(6);
            this.lb_spotify.Name = "lb_spotify";
            this.lb_spotify.Size = new System.Drawing.Size(434, 629);
            this.lb_spotify.TabIndex = 7;
            // 
            // lb_Catagory
            // 
            this.lb_Catagory.AutoSize = true;
            this.lb_Catagory.Location = new System.Drawing.Point(24, 260);
            this.lb_Catagory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Catagory.Name = "lb_Catagory";
            this.lb_Catagory.Size = new System.Drawing.Size(105, 25);
            this.lb_Catagory.TabIndex = 8;
            this.lb_Catagory.Text = "Catagory:";
            // 
            // bt_searchPlaylist
            // 
            this.bt_searchPlaylist.Location = new System.Drawing.Point(446, 248);
            this.bt_searchPlaylist.Margin = new System.Windows.Forms.Padding(6);
            this.bt_searchPlaylist.Name = "bt_searchPlaylist";
            this.bt_searchPlaylist.Size = new System.Drawing.Size(202, 44);
            this.bt_searchPlaylist.TabIndex = 10;
            this.bt_searchPlaylist.Text = "Search Playlist";
            this.bt_searchPlaylist.UseVisualStyleBackColor = true;
            this.bt_searchPlaylist.Click += new System.EventHandler(this.Bt_searchPlaylist_Click);
            // 
            // cb_country
            // 
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(30, 196);
            this.cb_country.Margin = new System.Windows.Forms.Padding(6);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(238, 33);
            this.cb_country.TabIndex = 11;
            // 
            // cb_catagory
            // 
            this.cb_catagory.FormattingEnabled = true;
            this.cb_catagory.Location = new System.Drawing.Point(30, 290);
            this.cb_catagory.Margin = new System.Windows.Forms.Padding(6);
            this.cb_catagory.Name = "cb_catagory";
            this.cb_catagory.Size = new System.Drawing.Size(238, 33);
            this.cb_catagory.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(297, 196);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Song Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 677);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cb_catagory);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.bt_searchPlaylist);
            this.Controls.Add(this.lb_Catagory);
            this.Controls.Add(this.lb_spotify);
            this.Controls.Add(this.bt_searchSong);
            this.Controls.Add(this.lb_country);
            this.Controls.Add(this.lb_connected);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_connected;
        private System.Windows.Forms.Label lb_country;
        private System.Windows.Forms.Button bt_searchSong;
        private System.Windows.Forms.ListBox lb_spotify;
        private System.Windows.Forms.Label lb_Catagory;
        private System.Windows.Forms.Button bt_searchPlaylist;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.ComboBox cb_catagory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

