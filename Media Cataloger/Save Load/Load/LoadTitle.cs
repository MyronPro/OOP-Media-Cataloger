using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    
    public abstract class LoadTitle
    {
        public static void MediaType (string[] properties, List<Media> storeData)
        {
           
            if (properties[0] == "Video")

                LoadVid(properties, storeData);
           
                

            else if (properties[0] == "Music")

                LoadMusic(properties, storeData);

            else if (properties[0] == "Video Game")

                LoadGame(properties, storeData);

            else
            {
                Console.WriteLine("Failed to Find Item Type");
                Console.ReadLine();
            }

        }

        private static void LoadVid (string[] properties, List<Media> storeData)
        {
           
            if (properties[4] == "Digital" || properties[4] == "digital")           
                
                storeData.Add(new DigitalVid(properties[1], properties[2], properties[3], properties[5], properties[6], properties[7], properties[8]));
            
                
            else

                storeData.Add(new PhysVid(properties[1], properties[2], properties[3], properties[4], properties[5],
                    properties[6], properties[7], properties[8], properties[9]));
            
                
        }

        private static void LoadMusic(string[] properties, List<Media> storeData)
        {
            if (properties[4] == "Digital" || properties[4] == "digital")
            
                storeData.Add(new DigitalMusic(properties[1], properties[2], properties[3], properties[4], properties[6], properties[7]));
            
       
            else
            
                storeData.Add(new PhysMusic(properties[1], properties[2], properties[3], properties[4], properties[5], 
                    properties[6], properties[7], properties[8]));
            
        }

        private static void LoadGame(string[] properties, List<Media> storeData)
        {
            if (properties[4] == "Digital" || properties[4] == "digital")

                storeData.Add(new DigitalVG(properties[1], properties[2], properties[3], properties[5], 
                    properties[6], properties[7], properties[8], properties[9]));


            else

                storeData.Add(new PhysicalVG(properties[1], properties[2], properties[3], properties[5],
                    properties[6], properties[7], properties[8], properties[9], properties[10]));
        }

    }
}
