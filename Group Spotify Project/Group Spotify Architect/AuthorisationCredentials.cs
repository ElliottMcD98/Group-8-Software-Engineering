using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;

namespace Group_Spotify_Architect
{
    public class AuthorisationCredentials
    {
        private string ClientId { get; set; }
        private string ClientSecret { get; set; }
        public PrivateProfile User { get; set; }
        public SpotifyWebAPI WebApi { get; set; }

        public void Connect()
        {
            GetUserAsync(new CredentialsAuth("fd5c6f20a3dd4a08bea0ef24a1d440b6", "56b2a1f00f754df2af0292fc08714f2e"));
        }

        public async void GetUserAsync(CredentialsAuth auth)
        {
            Token token = await auth.GetToken();
            WebApi = new SpotifyWebAPI { AccessToken = token.AccessToken, TokenType = token.TokenType };
            User = await WebApi.GetPrivateProfileAsync();
        }
    }
}
