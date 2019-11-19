namespace Group_Spotify_Architect
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.lb_connected = new System.Windows.Forms.Label();
            this.lb_country = new System.Windows.Forms.Label();
            this.lb_spotify = new System.Windows.Forms.ListBox();
            this.lb_Catagory = new System.Windows.Forms.Label();
            this.bt_searchPlaylist = new System.Windows.Forms.Button();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_catagory = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nud_Song = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_songs = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.tB_SongAmount = new System.Windows.Forms.TrackBar();
            this.lb_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Song)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_SongAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_connected
            // 
            this.lb_connected.AutoSize = true;
            this.lb_connected.Location = new System.Drawing.Point(58, 9);
            this.lb_connected.Name = "lb_connected";
            this.lb_connected.Size = new System.Drawing.Size(79, 13);
            this.lb_connected.TabIndex = 1;
            this.lb_connected.Text = "Not Connected";
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.lb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_country.Location = new System.Drawing.Point(12, 47);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(64, 18);
            this.lb_country.TabIndex = 4;
            this.lb_country.Text = "Country:";
            // 
            // lb_spotify
            // 
            this.lb_spotify.BackColor = System.Drawing.SystemColors.WindowText;
            this.lb_spotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_spotify.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_spotify.FormattingEnabled = true;
            this.lb_spotify.ItemHeight = 18;
            this.lb_spotify.Location = new System.Drawing.Point(12, 170);
            this.lb_spotify.Name = "lb_spotify";
            this.lb_spotify.Size = new System.Drawing.Size(469, 202);
            this.lb_spotify.TabIndex = 7;
            this.lb_spotify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_spotify_MouseDoubleClick);
            // 
            // lb_Catagory
            // 
            this.lb_Catagory.AutoSize = true;
            this.lb_Catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_Catagory.Location = new System.Drawing.Point(141, 47);
            this.lb_Catagory.Name = "lb_Catagory";
            this.lb_Catagory.Size = new System.Drawing.Size(72, 18);
            this.lb_Catagory.TabIndex = 8;
            this.lb_Catagory.Text = "Category:";
            // 
            // bt_searchPlaylist
            // 
            this.bt_searchPlaylist.BackColor = System.Drawing.Color.Gold;
            this.bt_searchPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_searchPlaylist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bt_searchPlaylist.Location = new System.Drawing.Point(187, 115);
            this.bt_searchPlaylist.Name = "bt_searchPlaylist";
            this.bt_searchPlaylist.Size = new System.Drawing.Size(101, 23);
            this.bt_searchPlaylist.TabIndex = 10;
            this.bt_searchPlaylist.Text = "Search Playlist";
            this.bt_searchPlaylist.UseVisualStyleBackColor = false;
            this.bt_searchPlaylist.Click += new System.EventHandler(this.Bt_searchPlaylist_Click);
            // 
            // cb_country
            // 
            this.cb_country.BackColor = System.Drawing.SystemColors.WindowText;
            this.cb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_country.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(15, 68);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(121, 26);
            this.cb_country.TabIndex = 11;
            // 
            // cb_catagory
            // 
            this.cb_catagory.BackColor = System.Drawing.SystemColors.MenuText;
            this.cb_catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_catagory.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_catagory.FormattingEnabled = true;
            this.cb_catagory.Location = new System.Drawing.Point(142, 68);
            this.cb_catagory.Name = "cb_catagory";
            this.cb_catagory.Size = new System.Drawing.Size(121, 26);
            this.cb_catagory.TabIndex = 12;
            // 
            // nud_Song
            // 
            this.nud_Song.BackColor = System.Drawing.SystemColors.WindowText;
            this.nud_Song.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nud_Song.ForeColor = System.Drawing.SystemColors.Window;
            this.nud_Song.Location = new System.Drawing.Point(444, 70);
            this.nud_Song.Margin = new System.Windows.Forms.Padding(2);
            this.nud_Song.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_Song.Name = "nud_Song";
            this.nud_Song.Size = new System.Drawing.Size(37, 24);
            this.nud_Song.TabIndex = 13;
            this.nud_Song.ValueChanged += new System.EventHandler(this.nud_Song_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(266, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Song Amount:";
            // 
            // lb_songs
            // 
            this.lb_songs.AutoSize = true;
            this.lb_songs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_songs.Location = new System.Drawing.Point(10, 140);
            this.lb_songs.Name = "lb_songs";
            this.lb_songs.Size = new System.Drawing.Size(97, 18);
            this.lb_songs.TabIndex = 16;
            this.lb_songs.Text = "Song Playlist:";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(12, 9);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(40, 13);
            this.lb_status.TabIndex = 17;
            this.lb_status.Text = "Status:";
            // 
            // tB_SongAmount
            // 
            this.tB_SongAmount.BackColor = System.Drawing.Color.SeaGreen;
            this.tB_SongAmount.Location = new System.Drawing.Point(269, 68);
            this.tB_SongAmount.Maximum = 50;
            this.tB_SongAmount.Minimum = 1;
            this.tB_SongAmount.Name = "tB_SongAmount";
            this.tB_SongAmount.Size = new System.Drawing.Size(170, 45);
            this.tB_SongAmount.TabIndex = 18;
            this.tB_SongAmount.Value = 25;
            this.tB_SongAmount.ValueChanged += new System.EventHandler(this.tB_SongAmount_ValueChanged);
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.BackColor = System.Drawing.Color.Gold;
            this.lb_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_info.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_info.Location = new System.Drawing.Point(152, 416);
            this.lb_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(175, 20);
            this.lb_info.TabIndex = 19;
            this.lb_info.Text = "Double click song to play";
            this.lb_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(492, 462);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.tB_SongAmount);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_songs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_Song);
            this.Controls.Add(this.cb_catagory);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.bt_searchPlaylist);
            this.Controls.Add(this.lb_Catagory);
            this.Controls.Add(this.lb_spotify);
            this.Controls.Add(this.lb_country);
            this.Controls.Add(this.lb_connected);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Group Spotify Architect";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Song)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_SongAmount)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nud_Song;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_songs;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.TrackBar tB_SongAmount;
        private System.Windows.Forms.Label lb_info;
    }
}

