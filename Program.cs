using System;
using System.IO;
using System.Text.Json;

namespace _2021_03_05_JSON_GUI
{//serialization
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Section 1:
            - Open environment directory.
            - Get amount level directories.
            - Open level directories.
            - Get names of all level tile maps.
            - Create a levels class.
            - Store names in dictionary.
            - Create a StreamWriter variable.
            - Serialize the dictionary data to json format using a stream writer.
            
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
                
                if(!Directory.Exists(@"./maps"))
                {
                    Console.WriteLine("maps directory does not exist!");
                    Console.WriteLine("Use, \"json_maps -f <amount>\"");
                }
                else 
                {
                    try
                    {
                        level list_of_levels = new level();

                        DirectoryInfo current_directory = new DirectoryInfo(Environment.CurrentDirectory + @"./maps");

                        if(!(current_directory.GetDirectories().Length == 0))
                        {
                            int number_of_levels = current_directory.GetDirectories().Length;

                            for(int i = 0; i <= number_of_levels; i++)
                            {
                                //list_of_levels.levels.Add("level_" + i, Directory.EnumerateFiles(current_directory.FullName + @"./level_" + i, ".tmx"));
                            }
                        }
                        else
                        {
                            Console.Write("There are no levels!\nAdd some level directories with .tmx map data to serialize the json map information!");
                        }
                    }
                    catch(Exception e)
                    {

                    }
                }
                
            }
            else if(args[0].Equals("-f"))
            {
                if(!Directory.Exists(@"./maps"))
                {
                    Directory.CreateDirectory(@"./maps");
                }
                
                try
                {
                    if(Directory.GetDirectories(@"./maps").Length == 0)
                    {
                        int number_out;
                        Span<char> number = new Span<char>(args[0].ToCharArray());
                        bool is_number = Int32.TryParse(number, out number_out);

                        if(is_number)
                        {
                            for (int i = 1; i <= Int32.Parse(args[1]); i++)
                            {
                                Directory.CreateDirectory(@"./maps/level_" + i);
                            }
                        }
                        else
                        {
                            Console.Write("Argument 2 is not a number!:\nUse, \"json_maps -f <amount>\"");
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.Write("Argument 2 is not a number!:\nUse, \"json_maps -f <amount>\"");
                } 
            }
        }
    }
}
