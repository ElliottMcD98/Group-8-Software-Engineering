using Group_Spotify_Architect;
using Moq;
using NUnit.Framework;
using NewsAPI.Constants;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SpotifyAppNUnitTestProject
{
    public class AlgorithmUnitTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public async Task CheckAlgorithmWorks()
        {
            const Countries country = Countries.GB;
            const Categories category = Categories.Science;
            const int size = 3;

            var spotifyInterface = new Mock<SpotifyInterface>();
            var songs = new List<Song>()
            {
                new Song("Song1","Artist1","Link1"),
                new Song("Song2","Artist2","Link2"),
                new Song("Song3","Artist3","Link3")
            };
            spotifyInterface.Setup(x => x.GetSongsAsync(It.IsAny<string>(), It.IsAny<int>())).ReturnsAsync(songs);
                
            var newsInterface = new Mock<NewsInterface>();
            

            var sut = new Algorithm(spotifyInterface.Object, newsInterface.Object);

            var result = await sut.SearchPlaylistAsync(country, category, size);

            Assert.IsInstanceOf<List<Song>>(result);
            Assert.AreEqual(size, result.Count);
        }
    }
}
