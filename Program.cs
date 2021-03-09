using System;
using System.IO;

namespace _2021_03_05_JSON_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Section 1:
            - Open environment directory.
            - Get level directories.
            - Open level directories.
            - Get names of all level tile maps.
            - Store names in maps.json example format.
            - Write to maps.json file.
            
            Section 1 Example:
            json_maps -l

            Section 2:
            - Make maps directory.
            - In the maps directory create specified amounts of level directories.

            Section 2 Example:
            json_maps -f 100

            Section 3:
            - Print out help details.

            Section 3 Example:
            json_maps -h or json_maps --help
            */

            if(args[0].Equals("-l"))
            {
                if(!Directory.Exists(@".\maps"))
                {
                    Console.WriteLine("maps directory does not exist!");
                    Console.WriteLine("Use, \"json_maps -f <amount>\"");
                }
                else 
                {
                    DirectoryInfo current_directory = new DirectoryInfo(Environment.CurrentDirectory + @"\maps");
                    Console.WriteLine(current_directory.FullName);
                }
                
            }
            else if(args[0].Equals("-f"))
            {
                if(!Directory.Exists(@".\maps")) Directory.CreateDirectory(@".\maps");

                try
                {
                    Int32.Parse(args[1]);
                    for (int i = 0; i <= Int32.Parse(args[1]); i++)
                    {
                        Directory.CreateDirectory(@".\maps\level_" + i);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
