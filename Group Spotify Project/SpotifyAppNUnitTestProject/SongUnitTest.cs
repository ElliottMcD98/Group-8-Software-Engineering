using Group_Spotify_Architect;
using NUnit.Framework;

namespace SpotifyAppNUnitTestProject
{
    public class SongUnitTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void CheckTitleIsReturnedCorrectly()
        {
            const string ExpectedTitle = "Test Title";

            var sut = new Song(ExpectedTitle, "Test Artist", "Test Link");
            Assert.AreEqual(ExpectedTitle, sut.Title);
        }

        [Test]
        public void CheckArtistIsReturnedCorrectly()
        {
            const string ExpectedArtist = "Test Artist";

            var sut = new Song("Title", ExpectedArtist, "Test Link");
            Assert.AreEqual(ExpectedArtist, sut.Artist);
        }

        [Test]
        public void CheckLinkIsReturnedCorrectly()
        {
            const string ExpectedLink = "Test Link";

            var sut = new Song("Title", "Artist", ExpectedLink);
            Assert.AreEqual(ExpectedLink, sut.Link);
        }

        [Test]
        public void CheckToStringReturnsTitleAndArtist()
        {
            const string ExpectedTitle = "ToString Title";
            const string ExpectedArtist = "Test Artist";

            var sut = new Song(ExpectedTitle, ExpectedArtist, "Link");

            Assert.AreEqual(ExpectedTitle + " - " + ExpectedArtist, sut.ToString());
        }

    }
}
