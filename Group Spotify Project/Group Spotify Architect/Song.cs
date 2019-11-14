namespace Group_Spotify_Architect
{
    class Song
    {
        private string title;
        private string artist;
        private string link;
        public string Title {
            get {
                return this.title;
            }
            set {
                this.title = value;
            }
        }
        public string Artist {
            get {
                return this.artist;
            }
            set {
                this.artist = value;
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

        public Song(string Title, string Artist, string Link)
        {
            this.Title = Title;
            this.Artist = Artist;
            this.Link = Link;
        }
        public override string ToString()
        {
            return $"{Title} - {Artist}";
        }
    }
}
