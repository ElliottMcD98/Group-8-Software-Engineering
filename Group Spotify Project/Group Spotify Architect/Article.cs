namespace Group_Spotify_Architect
{
    class Article
    {
        private string title;
        private string desc;
        private string link;
        public string Title {
            get {
                return this.title;
            }
            set {
                this.title = value;
            }
        }
        public string Desc {
            get {
                return this.desc;
            }
            set {
                this.desc = value;
            }
        }
        public string Link {
            get {
                return this.link;
            }
            set {
                this.link = value;
            }
        }

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
