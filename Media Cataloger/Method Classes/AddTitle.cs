using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public abstract class AddTitle
    {


        public static void LibrarySelect(List<Media> mediaList, string lib)
        {

            if (lib == "Video")
                NewVid(mediaList);

            else if (lib == "Music")
                NewMusic(mediaList);

            else if (lib == "Game")
                NewGame(mediaList);
        }

        public static void LibrarySelect(List<Media> mediaList)
        {
            Console.Clear();

            Console.WriteLine("Which library does this title belong to?");
            Console.WriteLine("1) Video Library");
            Console.WriteLine("2) Music Library");
            Console.WriteLine("3) Video Game Library");

            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1)
                NewVid(mediaList);

            else if (input.Key == ConsoleKey.D2)
                NewMusic(mediaList);

            else if (input.Key == ConsoleKey.D3)
                NewGame(mediaList);
        }

        private static string DigitalTitle (string name)
        {

            Console.WriteLine("\nWhat service do you own {0} through?", name);
            string service = Console.ReadLine();

            return service;
        }


        private static void NewVid(List<Media> mediaList )
        {
            Console.Clear();

            Console.WriteLine("Enter the title: ");
            string newTitle = Console.ReadLine();
            Console.WriteLine("\nEnter Video Format: ");
            string format = Console.ReadLine();

            if (format == "Digital" || format == "digital")
            {
                string sp = AddTitle.DigitalTitle(newTitle);
                mediaList.Add(new DigitalVid(newTitle, sp));
            }

            else
                mediaList.Add(new PhysVid(newTitle, format));
            
        }

        private static void NewMusic(List<Media> mediaList)
        {
            Console.Clear();


            Console.WriteLine("Enter the Album Title: ");
            string newTitle = Console.ReadLine();

            Console.WriteLine("\nEnter the Artist: ");
            string artist = Console.ReadLine();

            Console.WriteLine("\nEnter Music Format: ");
            string format = Console.ReadLine();

            if (format == "Digital" || format == "digital")
            {              
                string sp = AddTitle.DigitalTitle(newTitle);
                mediaList.Add(new DigitalMusic(newTitle, artist, sp));
            }

            else
                mediaList.Add(new PhysMusic(newTitle, artist, format));

        }

        private static void NewGame(List<Media> mediaList)
        {
            Console.Clear();

            Console.WriteLine("Enter the Game Title: ");
            string newTitle = Console.ReadLine();

            Console.WriteLine("\nEnter the Platform: ");
            string platform = Console.ReadLine();

            Console.WriteLine("\nIs {0} a Physical or Digital title?", newTitle);
            string format = Console.ReadLine();

            if (format == "Digital" || format == "digital")
            {
                string sp = AddTitle.DigitalTitle(newTitle);
                mediaList.Add(new DigitalVG(newTitle, platform, sp));
            }

            else
                mediaList.Add(new PhysicalVG(newTitle, platform));

        }


    }
}
