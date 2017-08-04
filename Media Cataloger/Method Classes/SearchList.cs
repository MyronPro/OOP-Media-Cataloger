using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public abstract class SearchList
    {


        private static string GetTitle()
        {

            Console.WriteLine("Which Title would you like to view?");
            string title = Console.ReadLine();

            return title;
        }


        public static int PosInList(List<Media> mediaList)
        {
            string title = GetTitle();

            for (int i = 0; i < mediaList.Capacity; i++)
            {
                var vidx = mediaList[i];
                if (vidx.Name == title)
                    return i;
            }

            return -1;
        }


    }
}
