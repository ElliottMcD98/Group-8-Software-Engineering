namespace Group_Spotify_Architect
{
    class Song
    {
        public string Title;
        public string Artist;
        public string Link;
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
