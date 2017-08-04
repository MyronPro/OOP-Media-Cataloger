using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Media_Cataloger
{
    public abstract class LoadFromFile
    {
        public static void ReadFile (List<Media> mediaList )
        {
            string title = ListTitle();

            string filePath = @"C:\Users\User\Desktop\Media Cataloger\" + title;

            Console.Clear();

            try
            {
                StreamReader SR = new StreamReader(filePath);

                int z = 0;
                string[] properties = new string[13];

                //skip first 3 lines
                for (int i = 0; i < 3; i++)
                    SR.ReadLine();


                while (!SR.EndOfStream)
                {
                    string items = SR.ReadLine();
                    string[] itemProperty = items.Split('\t');
                  
                    if (itemProperty.Length > 1)
                    {
                        properties[z] = itemProperty[1];
                        z++;
                       
                    }
                    if(items == String.Empty && z != 0 )
                    {
                        LoadTitle.MediaType(properties, mediaList);
                        z = 0;
                    }

                }
                SR.Close();
                Console.WriteLine("{0} Loaded Successfully", title);
            }
           
            catch
            {
                Console.WriteLine("{0} Could Not Be found", title);
            }


            Console.ReadLine();
           
        }

        private static string ListTitle()
        {
            Console.Clear();

            Console.WriteLine("Name of List to Load:");
            string listName = Console.ReadLine();

            return listName + ".txt";
        }

        private static void PropertySort(string[] propArray)
        {
            if (propArray[0] == "Video")
                Console.WriteLine("True");
        }
    }
}
