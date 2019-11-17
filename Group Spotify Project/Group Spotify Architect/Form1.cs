using System;
using System.Windows.Forms;

namespace Group_Spotify_Architect
{
    public partial class UserInterface : Form
    {
        private SpotifyInterface spotify;
        private NewsInterface news;

        public UserInterface()
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

            tB_SongAmount.Value = 25;
            nud_Song.Value = 25;
        }


        private async void Bt_searchPlaylist_Click(object sender, EventArgs e)
        {
            NewsAPI.Constants.Countries cont;
            NewsAPI.Constants.Categories cat;
            Algorithm algorithm = new Algorithm(ref spotify, ref news);

            Enum.TryParse<NewsAPI.Constants.Countries>(cb_country.SelectedValue.ToString(), out cont);
            Enum.TryParse<NewsAPI.Constants.Categories>(cb_catagory.SelectedValue.ToString(), out cat);

            var search = await algorithm.SearchPlaylistAsync(cont, cat, Convert.ToInt32(nud_Song.Value));

            lb_spotify.Items.Clear();

            for (int x = 0; x < search.Count; x++)
            {
                lb_spotify.Items.Add(search[x]);
            }
        }

        private void nud_Song_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (nud_Song.Value > tB_SongAmount.Maximum)
                {
                    nud_Song.Value = tB_SongAmount.Maximum;
                }

                if (nud_Song.Value < tB_SongAmount.Minimum)
                {
                    nud_Song.Value = tB_SongAmount.Minimum;
                }
            }
            catch
            {
                throw;
            }
        }

        private void tB_SongAmount_ValueChanged(object sender, EventArgs e)
        {
            nud_Song.Value = tB_SongAmount.Value;
        }

        private void lb_spotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lb_spotify.SelectedItem != null)
            {
                try
                {
                    Song tmp = (Song)lb_spotify.SelectedItem;
                    System.Diagnostics.Process.Start(tmp.Link);
                }
                catch {}
            }
        }
    }
}
