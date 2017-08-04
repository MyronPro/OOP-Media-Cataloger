using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public class DigitalVid : Video, IDigital
    {

        public override string Format { get { return "Digital"; } } 

        public string DigitalService { get; set; }
        public string FileSize { get; set; }
       
       

        public DigitalVid (string name,  string digitalService ) : base(name)
        {
            this.DigitalService = digitalService;
        }



        public DigitalVid(string name, string release, string genre, string director, string runtime, string digitalService, string fileSize) 
            : base(name, release, genre, director, runtime)
        {
            this.DigitalService = digitalService;
            this.FileSize = fileSize;
        }


        public override bool UpdateFields()
        {
            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.Write("Update Title {0} to ", this.Name);
                var update = Console.ReadLine();
                this.Name = update;
            }

            else if (input.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.Write("Enter Release Date in mm/dd/yyyy format: ");
                var update = DateTime.Parse(Console.ReadLine());
                this.Release = update;
            }

            else if (input.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.Write("Update Genre of {0} to ", this.Name);
                var update = Console.ReadLine();
                this.Genre = update;
            }

            else if (input.Key == ConsoleKey.D4)
            {
                Console.Clear();
                Console.Write("Update Format of {0} to ", this.Name);
                var update = Console.ReadLine();
                this.Format = update;
            }

            else if (input.Key == ConsoleKey.D5)
            {
                Console.Clear();
                Console.Write("Update Director of {0} to ", this.Name);
                var update = Console.ReadLine();
                this.Director = update;
            }

            else if (input.Key == ConsoleKey.D6)
            {
                Console.Clear();
                Console.Write("Update Runtime of {0} to ", this.Name);
                var update = Console.ReadLine();
                this.Length = update;
            }

            else if (input.Key == ConsoleKey.D7)
            {
                Console.Clear();
                Console.Write("Update Digital Service: ");
                var update = Console.ReadLine();
                this.Format = update;
            }

            else if (input.Key == ConsoleKey.D8)
            {
                Console.Clear();
                Console.Write("File Size of {0}: ", this.Name);
                var update = Console.ReadLine();
                this.FileSize = update;
            }

            else if (input.Key == ConsoleKey.Backspace)
                return true;

            return false;

        }

        public override string ToString()
        {
            string text = null;

            text += "\r\nType:\t" + this.Type + "\r\n";
            text += "Title:\t" + this.Name + "\r\n";
            text += "Release:\t" + this.Release.ToShortDateString() + "\r\n";
            text += "Genre:\t" + this.Genre + "\r\n";
            text += "Format:\t" + this.Format + "\r\n";
            text += "Director:\t" + this.Director + "\r\n";
            text += "Runtime:\t" + this.Length + "\r\n";
            text += "Digital Service:\t" + this.DigitalService + "\r\n";
            text += "File Size:\t" + this.FileSize + "\r\n";
         
            return text;
        }

    }
}
