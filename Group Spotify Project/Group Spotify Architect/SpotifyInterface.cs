using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Group_Spotify_Architect
{
    class SpotifyInterface
    {
        SpotifyWebAPI webAPI;
        PrivateProfile user;
        public SpotifyInterface()
        {

        }
        public void Connect()
        {
            GetToken(new CredentialsAuth("fd5c6f20a3dd4a08bea0ef24a1d440b6", "56b2a1f00f754df2af0292fc08714f2e"));
        }
        public async void GetToken(CredentialsAuth auth)
        {
            Token token = await auth.GetToken();
            webAPI = new SpotifyWebAPI { AccessToken = token.AccessToken, TokenType = token.TokenType };
            user = await webAPI.GetPrivateProfileAsync();
        }
        public async void CreatePlaylist(string userID, string title, string[] songs)
        {
            var tmp = await webAPI.CreatePlaylistAsync(userID, title, false);

            foreach (var item in songs)
            {
                await webAPI.AddPlaylistTrackAsync(tmp.Id, item);
            }
        }
        public async Task<List<Song>> GetSongs(string title, int size = 25)
        {
            var output = new List<Song>();
            var tmp = await webAPI.SearchItemsAsync(title, SpotifyAPI.Web.Enums.SearchType.Track, size);
            foreach (var item in tmp.Tracks.Items)
            {
                output.Add(new Song(item.Name, item.Artists[0].Name, item.Uri));
            }
            return output;
        }
    }
}
