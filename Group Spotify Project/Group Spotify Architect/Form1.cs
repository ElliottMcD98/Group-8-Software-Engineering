using System;
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
            try
            {
                spotify.Connect();
                lb_connected.Text = "Connected";
            }
            catch (Exception err)
            {
                lb_connected.Text = $"Error: {err.Message}";
            }

            cb_catagory.DataSource = Enum.GetValues(typeof(NewsAPI.Constants.Categories));
            cb_country.DataSource = Enum.GetValues(typeof(NewsAPI.Constants.Countries));
            cb_country.SelectedItem = NewsAPI.Constants.Countries.GB;
        }

        private async void bt_searchSong_Click(object sender, EventArgs e)
        {
            Algorithm algorithm = new Algorithm(ref spotify, ref news);
            NewsAPI.Constants.Countries cont;
            Enum.TryParse<NewsAPI.Constants.Countries>(cb_country.SelectedValue.ToString(), out cont);
            NewsAPI.Constants.Categories cat;
            Enum.TryParse<NewsAPI.Constants.Categories>(cb_country.SelectedValue.ToString(), out cat);
            var search = await algorithm.SearchSong(cont, cat);
            lb_spotify.Items.Clear();
            lb_spotify.Items.Add(search);
        }

        private async void Bt_searchPlaylist_Click(object sender, EventArgs e)
        {
            Algorithm algorithm = new Algorithm(ref spotify, ref news);
            NewsAPI.Constants.Countries cont;
            Enum.TryParse<NewsAPI.Constants.Countries>(cb_country.SelectedValue.ToString(), out cont);
            NewsAPI.Constants.Categories cat;
            Enum.TryParse<NewsAPI.Constants.Categories>(cb_country.SelectedValue.ToString(), out cat);
            var search = await algorithm.SearchPlaylist(cont, cat, Convert.ToInt32(numericUpDown1.Value));
            lb_spotify.Items.Clear();
            for (int x = 0; x < search.Count; x++)
            {
                lb_spotify.Items.Add(search[x]);
            }

        }
    }
}
