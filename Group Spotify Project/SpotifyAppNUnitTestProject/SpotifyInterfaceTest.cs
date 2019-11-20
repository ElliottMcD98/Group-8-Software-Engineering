using Group_Spotify_Architect;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyAppNUnitTestProject
{
    public class SpotifyInterfaceTest
    {
        [Test]
        public void Test1()
        {
            var songs = new string[]
            {
                "Song1","Song2","Song3"
            };
            var sut = new SpotifyInterface();
            sut.CreatePlaylistAsync("UserID", "Title", songs);
        }
    }
}
