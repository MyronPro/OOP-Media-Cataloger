using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public abstract class Music : Media
    {

        public override string Type { get { return "Music"; } }
        public string Artist { get; set; }
       
        public Music (string albumTitle, string artist) : base(albumTitle)
        {
            this.Artist = artist;
        }

        public Music (string albumTitle, string artist, string release, string genre) : base(albumTitle, release, genre)
        {
            this.Artist = artist;
        }

        public abstract override bool UpdateFields();

        public static void DisplayList(List<Media> list)
        {
            Console.Clear();
           
            foreach (var musicType in list.OfType<Music>())
            {
                Console.WriteLine("\n{0}\n{1}\n{2}", musicType.Name, musicType.Artist, musicType.Format);
            }

        }


    }
}
