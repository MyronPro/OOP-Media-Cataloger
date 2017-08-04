using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public abstract class Video : Media
    {
        public override string Type { get { return "Video"; } }
        public string Director { get; set; }
        public string Length { get; set; }

        public Video(string name) : base(name) { }

        public Video(string name, string release, string genre, string director, string runtime) 
            : base(name, release, genre)
        {
            this.Director = director;
            this.Length = runtime;
        }

        public abstract override bool UpdateFields();
        
        public static void DisplayList(List<Media> list)
        {
            Console.Clear();

            foreach (Media per in list.OfType<Video>())
            {
                Console.WriteLine("\n{0}\n{1}", per.Name, per.Format);
            }

        }

       
    }
}
