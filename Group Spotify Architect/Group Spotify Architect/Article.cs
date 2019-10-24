using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
