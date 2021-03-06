﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public class PhysicalVG : VideoGame, IPhysical
    {
        public override string Format { get { return "Physical"; } }

        public string Condition { get; set; }
        public bool Case { get; set; }
        public bool Manual { get; set; }

        public PhysicalVG (string name, string platform) : base (name, platform) { }

        public PhysicalVG(string name, string release, string genre, string platform, string publisher, string studio, string cas, string manual, string condition)
            : base (name, release, genre, platform, publisher, studio)
        {

            if (cas == "true")
                this.Case = true;
            else
                this.Case = false;

            if (manual == "true")
                this.Manual = true;
            else
                this.Manual = false;

            this.Condition = condition;
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
                Console.Write("Update Platform of {0} to ", this.Name);
                var update = Console.ReadLine();
                this.Platform = update;
            }


            else if (input.Key == ConsoleKey.D6)
            {
                Console.Clear();
                Console.Write("Update Publisher of {0} to ", this.Name);
                var update = Console.ReadLine();
                this.Publisher = update;
            }

            else if (input.Key == ConsoleKey.D7)
            {
                Console.Clear();
                Console.Write("Update Design Studio of {0} to ", this.Name);
                var update = Console.ReadLine();
                this.DesignStudio = update;
            }

            else if (input.Key == ConsoleKey.D8)
            {
                Console.Clear();
                Console.Write("Does {0} have a Case? (y/n) ", this.Name);
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                    this.Case = true;
                else
                    this.Case = false;
            }

            else if (input.Key == ConsoleKey.D9)
            {
                Console.Clear();
                Console.Write("Does {0} have a Booklet? (y/n) ", this.Name);
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                    this.Manual = true;
                else
                    this.Manual = false;
            }

            else if (input.Key == ConsoleKey.D0)
            {
                Console.Clear();
                Console.Write("Update Condition of {0} to ", this.Name);
                var update = Console.ReadLine();
                this.Condition = update;
            }

            else if (input.Key == ConsoleKey.Backspace)
                return true;

            return false;
        }

        //overidden ToString Method
        public override string ToString()
        {
            string text = null;
            text += "\r\nType:\t" + this.Type + "\r\n";
            text += "Title:\t" + this.Name + "\r\n";
            text += "Release:\t" + this.Release.ToShortDateString() + "\r\n";
            text += "Genre:\t" + this.Genre + "\r\n";
            text += "Format:\t" + this.Format + "\r\n";
            text += "Platform:\t" + this.Platform + "\r\n";
            text += "Publisher:\t" + this.Publisher + "\r\n";
            text += "Design Studio:\t" + this.DesignStudio + "\r\n";
            text += "Case:\t" + this.Case + "\r\n";
            text += "Booklet:\t" + this.Manual + "\r\n";
            text += "Condition:\t" + this.Condition + "\r\n";
            return text;
        }

    }
}
