using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string OriginalFileName { get; set; } 
        public Song(string title, string artist, string originalFileName = null)
        {
            Title = title;
            Artist = artist;
            OriginalFileName = originalFileName ?? $"{title} - {artist}";
        }

        public override string ToString()
        {
            return $"{Title};{Artist}";
        }
    }
}
