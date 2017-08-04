using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Media_Cataloger
{
    public abstract class SaveToFile
    {

        public static DateTime Today { get; }

        public static void Save(List<Media> contents)
        {
            try
            {
                string title = ListTitle();

                string filePath = DirectoryPath() + title;

                StreamWriter SW = new StreamWriter(filePath);


                SW.Write("Date: ");
                SW.WriteLine(DateTime.Now.ToShortDateString());
                SW.WriteLine("----Save/Load Still a Work in Progress Please Don't Modify File----");


                foreach (var item in contents)
                {
                    SW.WriteLine(item.ToString());
                }

                SW.Close();

                Console.WriteLine("List saved as {0}", title);
                Console.ReadLine();
            }

            catch
            {
                Console.WriteLine("Save Failed");
                Console.ReadLine();
            }
            
           
        }

        private static string ListTitle ()
        {
            Console.Clear();

            Console.WriteLine("Save List As:");
            string listName = Console.ReadLine(); 

            return listName + ".txt";
        }

        private static string DirectoryPath ()
        {
            if(!Directory.Exists(@"C:\Users\User\Desktop\Media Cataloger"))
                Directory.CreateDirectory(@"C:\Users\User\Desktop\Media Cataloger");

            string path = @"C:\Users\User\Desktop\Media Cataloger\";

            return path;
        }
    }
}
