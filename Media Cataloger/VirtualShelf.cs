using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading; 
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public class Virtual_Shelf
    {

        List<Media> groupList = new List<Media>();

        ConsoleKeyInfo input;

        public Virtual_Shelf()
        {
            Console.WriteLine("Welcome to the Media Cataloging Tool");
            Console.ReadLine();
        }

        ~Virtual_Shelf()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using the Media Cataloger");
            Console.ReadLine();
        }
        
        private void AddNewMedia( string libselect )
        {
            Console.Clear();

            AddTitle.LibrarySelect(groupList, libselect);
            
            ViewLibraries(libselect);
        }

        private void DisplayListContents( string libselect )
        {
            Console.Clear();
            Thread.Sleep(100);
            Console.WriteLine("1) Ascending Order");
            Thread.Sleep(100);
            Console.WriteLine("2) Descending Order");

            input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1)
                groupList = groupList.OrderBy(x => x.Name).ToList();

            else if (input.Key == ConsoleKey.D2)
                groupList = groupList.OrderByDescending(x => x.Name).ToList();

            Console.Clear();

            if (libselect == "Video")
                Video.DisplayList(groupList);

            else if (libselect == "Music")
                Music.DisplayList(groupList);
            else if (libselect == "Game")
                VideoGame.DisplayList(groupList);

            Console.ReadLine();
            ViewLibraries(libselect);
        }

        private void DisplayListContents()
        {
            groupList = groupList.OrderBy(x => x.Type).ToList();

            Console.Clear();

            foreach (Media per in groupList)
            {
                Console.WriteLine("\n{0}\n{1}", per.Type, per.Name);
            }

            Console.ReadLine();

        }

        private void NotFound(List<Media> groupList)
        {
            Console.Clear();
            Console.WriteLine("Title Not Found\nWould you like to add it? (y/n)");

            input = Console.ReadKey();

            if (input.Key == ConsoleKey.Y)
                AddTitle.LibrarySelect(groupList);

            else if (input.Key == ConsoleKey.N)
            { }

            else
                NotFound(groupList);

        }

        private void viewTitle (List<Media> groupList)
        {
            Console.Clear();

            int searchResults = SearchList.PosInList(groupList);

            Console.Clear();

            if (searchResults == -1)
                NotFound(groupList);

            else
            {
                bool back;
                var objType = groupList[searchResults];

                do {
                    TitleView(objType);

                    back = objType.UpdateFields();

                } while(back == false);
               
            }

        }

        private void TitleView( Media objType)
        {
            ObjectDetails.MainDetails(objType);

            if (objType.Type == "Video")
                ObjectDetails.VideoDetails(objType);

            else if (objType.Type == "Music")
                ObjectDetails.MainDetails(objType);

            else if (objType.Type == "Video Game")
                ObjectDetails.GameDetails(objType);


            if (objType.Format == "Digital")
                ObjectDetails.DigitalDetails(objType);

            else
                ObjectDetails.PhysicalDetails(objType);
        }

        //User Interface Methods
      
        public void ViewMainLibrary()
        {
            Console.Clear();
            Console.WriteLine("Select a Library:\n");
            Thread.Sleep(100);
            Console.WriteLine("1) Video Library");
            Thread.Sleep(100);
            Console.WriteLine("2) Music Library");
            Thread.Sleep(100);
            Console.WriteLine("3) Video Game Library");
            Thread.Sleep(100);
            Console.WriteLine("4) View Entire Library List");
            Thread.Sleep(100);
            Console.WriteLine("5) Save List");
            Thread.Sleep(100);
            Console.WriteLine("6) Load List");
            Thread.Sleep(100);


            Console.WriteLine("\nEsc to Quit\n");

        }

        public bool MainLibraryOptions()
        {
            input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1)
                this.ViewLibraries("Video");

            else if (input.Key == ConsoleKey.D2)
                this.ViewLibraries("Music");

            else if (input.Key == ConsoleKey.D3)
                this.ViewLibraries("Game");

            else if (input.Key == ConsoleKey.D4)
                this.DisplayListContents();

            else if (input.Key == ConsoleKey.D5)
                SaveToFile.Save(groupList); 

            else if (input.Key == ConsoleKey.D6)
               LoadFromFile.ReadFile(groupList); 

            else if (input.Key == ConsoleKey.Escape)
                return true;

            return false;

        }


        private void ViewLibraries( string libselect )
        {

            Console.Clear();

            if (libselect == "Video")
                Console.WriteLine("Video Library\n");

            else if (libselect == "Music")
                Console.WriteLine("Music Library\n");

            else if (libselect == "Game")
                Console.WriteLine("Video Game Library\n");

            Thread.Sleep(100);
            Console.WriteLine("1) Add Title");

            Thread.Sleep(100);
            Console.WriteLine("2) Display {0} Library", libselect);

            Thread.Sleep(100);
            Console.WriteLine("3) View specfic Title");


            Thread.Sleep(100);
            Console.WriteLine("\nBackspace to return");

            this.LibrariesOptions( libselect );

        }

        private void LibrariesOptions( string libSelect )
        {

            input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1)
                this.AddNewMedia(libSelect);

            else if (input.Key == ConsoleKey.D2)
                this.DisplayListContents(libSelect);

            else if (input.Key == ConsoleKey.D3)
                this.viewTitle(groupList);

            else if (input.Key == ConsoleKey.Backspace)
            { }

            else
                this.ViewLibraries(libSelect);
        }
    }
}
