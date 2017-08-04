using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public abstract class ObjectDetails
    {
        
        public static void MainDetails(Media obj)
        {
            Console.Clear();
            Console.WriteLine("1) Name: {0}", obj.Name);
            Console.WriteLine("2) Release Date: {0}", obj.Release.ToShortDateString());
            Console.WriteLine("3) Genre: {0}", obj.Genre);
            Console.WriteLine("4) Format: {0}", obj.Format);   
        }

        public static void VideoDetails(Media vidType)
        {
            Video vid = (Video)vidType;
            Console.WriteLine("5) Director: {0}", vid.Director);
            Console.WriteLine("6) Runtime: {0}", vid.Length);
        }

        public static void MusicDetails(Media musicType)
        {
            Music music = (Music)musicType;
            Console.WriteLine("5) Artist: {0}", music.Artist);
        }

        public static void GameDetails(Media gameType)
        {
            VideoGame game = (VideoGame)gameType;
            Console.WriteLine("5) Platform: {0}", game.Platform);
            Console.WriteLine("6) Publisher: {0}", game.Publisher);
            Console.WriteLine("7) Design Studio: {0}", game.DesignStudio);
        }


        public static void DigitalDetails(Media digiType)

        {
            IDigital digi = (IDigital)digiType;

            if (digiType.Type == "Video")
            {
                Console.WriteLine("7) Digital Service: {0}", digi.DigitalService);
                Console.WriteLine("8) File Size: {0}", digi.FileSize);
            }

            else if (digiType.Type == "Music")
            {
                Console.WriteLine("6) Digital Service: {0}", digi.DigitalService);
                Console.WriteLine("7) File Size: {0}", digi.FileSize);
            }

            else if (digiType.Type == "Video Game")
            {
                Console.WriteLine("8) Digital Service: {0}", digi.DigitalService);
                Console.WriteLine("9) File Size: {0}", digi.FileSize);
            }
            
        }

        public static void PhysicalDetails(Media physType)
        {
            IPhysical phys = (IPhysical)physType;

            if (physType.Type == "Video")
            {
                Console.WriteLine("7) Case: {0}", phys.Case);
                Console.WriteLine("8) Booklet: {0}", phys.Manual);
                Console.WriteLine("9) Condition: {0}", phys.Condition);
            }
            
            else if (physType.Type == "Music")
            {
                Console.WriteLine("6) Case: {0}", phys.Case);
                Console.WriteLine("7) Booklet: {0}", phys.Manual);
                Console.WriteLine("8) Condition: {0}", phys.Condition);
            }

            else if (physType.Type == "Video Game")
            {
                Console.WriteLine("8) Case: {0}", phys.Case);
                Console.WriteLine("8) Booklet: {0}", phys.Manual);
                Console.WriteLine("0) Condition: {0}", phys.Condition);
            }
        }

       
    }
}
