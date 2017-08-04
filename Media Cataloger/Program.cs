using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    class Program
    {
        static void Main(string[] args)
        {
            var shelf = new Virtual_Shelf();

            Console.CursorVisible = false;

            bool endProg = false;

           

            do
            {
                shelf.ViewMainLibrary();
                endProg = shelf.MainLibraryOptions();
                
            } while (endProg == false);
           
            
        }
    }
}
