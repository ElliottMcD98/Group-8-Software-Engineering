using NUnit.Framework;

namespace Group_Spotify_Architect
{
    public class ArticleUnitTests
    {
        

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckTitleIsReturnedCorrectly()
        {
            const string ExpectedTitle = "Test Title";

            var sut = new Article(ExpectedTitle, "Test Descr","Test Link");
            Assert.AreEqual(ExpectedTitle, sut.Title);
        }
        [Test]
        public void CheckDescParamIsReturnedCorrectly()
        {
            const string ExpectedDescription = "Test Description"; 

            var sut = new Article("testt", ExpectedDescription, "Test Link");
            Assert.AreEqual(ExpectedDescription, sut.Desc);
        }

        [Test]
        public void CheckLinkParamIsReturnedCorrectly()
        {
            const string ExpectedLink = "Test Link";

            var sut = new Article("testt", "Description", ExpectedLink);
            Assert.AreEqual(ExpectedLink, sut.Link);
        }

        [Test]
        public void CheckToStringReturnsTitle()
        {
            const string ExpectedTitle = "ToString Title";

            var sut = new Article(ExpectedTitle, "Descr", "Link");

            Assert.AreEqual(ExpectedTitle, sut.ToString());
        }

    }
}
