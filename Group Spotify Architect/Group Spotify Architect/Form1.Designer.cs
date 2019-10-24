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
            this.bt_connect = new System.Windows.Forms.Button();
            this.lb_connected = new System.Windows.Forms.Label();
            this.lb_News = new System.Windows.Forms.ListBox();
            this.bt_GetNews = new System.Windows.Forms.Button();
            this.lb_search = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.lb_spotify = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(12, 28);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(75, 50);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "Connect to spotify";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // lb_connected
            // 
            this.lb_connected.AutoSize = true;
            this.lb_connected.Location = new System.Drawing.Point(12, 9);
            this.lb_connected.Name = "lb_connected";
            this.lb_connected.Size = new System.Drawing.Size(79, 13);
            this.lb_connected.TabIndex = 1;
            this.lb_connected.Text = "Not Connected";
            // 
            // lb_News
            // 
            this.lb_News.FormattingEnabled = true;
            this.lb_News.Location = new System.Drawing.Point(569, 13);
            this.lb_News.Name = "lb_News";
            this.lb_News.Size = new System.Drawing.Size(219, 420);
            this.lb_News.TabIndex = 2;
            // 
            // bt_GetNews
            // 
            this.bt_GetNews.Location = new System.Drawing.Point(488, 13);
            this.bt_GetNews.Name = "bt_GetNews";
            this.bt_GetNews.Size = new System.Drawing.Size(75, 50);
            this.bt_GetNews.TabIndex = 3;
            this.bt_GetNews.Text = "Get News";
            this.bt_GetNews.UseVisualStyleBackColor = true;
            this.bt_GetNews.Click += new System.EventHandler(this.bt_GetNews_Click);
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Location = new System.Drawing.Point(12, 105);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(86, 13);
            this.lb_search.TabIndex = 4;
            this.lb_search.Text = "search manually:";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(15, 122);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 5;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(16, 148);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(148, 23);
            this.bt_search.TabIndex = 6;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // lb_spotify
            // 
            this.lb_spotify.FormattingEnabled = true;
            this.lb_spotify.Location = new System.Drawing.Point(182, 13);
            this.lb_spotify.Name = "lb_spotify";
            this.lb_spotify.Size = new System.Drawing.Size(219, 420);
            this.lb_spotify.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_spotify);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.bt_GetNews);
            this.Controls.Add(this.lb_News);
            this.Controls.Add(this.lb_connected);
            this.Controls.Add(this.bt_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Label lb_connected;
        private System.Windows.Forms.ListBox lb_News;
        private System.Windows.Forms.Button bt_GetNews;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.ListBox lb_spotify;
    }
}

