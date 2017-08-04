using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public abstract class VideoGame : Media
    {
        public override string Type { get { return "Video Game"; } }

        public string Platform { get; set; }
        public string Publisher { get; set; }
        public string DesignStudio { get; set; }

        public VideoGame (string name, string platform) : base (name)
        {
            this.Platform = platform;
        }

        public VideoGame (string name, string release, string genre, string platform, string publisher, string studio) : base(name, release, genre)
        {
            this.Platform = platform;
            this.Publisher = publisher;
            this.DesignStudio = studio;
        }

        public abstract override bool UpdateFields();

        public static void DisplayList(List<Media> list)
        {
            Console.Clear();

        foreach (var gameType in list.OfType<VideoGame>())
        {
            Console.WriteLine("\n{0}\n{1}", gameType.Name, gameType.Platform);
        }

        }


    }
}
