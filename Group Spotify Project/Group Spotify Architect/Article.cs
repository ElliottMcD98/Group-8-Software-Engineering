namespace Group_Spotify_Architect
{
    class Article
    {
        public string Title;
        public string Desc;
        public string Link;
        public Article(string Title, string Desc, string Link)
        {
            this.Title = Title;
            this.Link = Link;
            this.Desc = Desc;
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
