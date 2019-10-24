using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Spotify_Architect
{
    public partial class Form1 : Form
    {
        private SpotifyInterface spotify;
        private NewsInterface news;
        public Form1()
        {
            InitializeComponent();
            spotify = new SpotifyInterface();
            news = new NewsInterface();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            try
            { 
                spotify.Connect();
                lb_connected.Text = "Connected";
            }
            catch (Exception err)
            {
                lb_connected.Text = $"Error: {err.Message}";
            }
        }

        private async void bt_GetNews_Click(object sender, EventArgs e)
        {
            var tmp = await news.GetHeadlines(NewsAPI.Constants.Countries.GB);
            lb_News.Items.Clear();
            lb_News.Items.AddRange(tmp.ToArray());
        }

        private async void bt_search_Click(object sender, EventArgs e)
        {
            var search = tb_search.Text;
            var results = await spotify.GetSongs(search);
            lb_spotify.Items.Clear();
            lb_spotify.Items.AddRange(results.ToArray());
        }
    }
}
