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
            Open environment directory.
            Get level directories.
            Open level directories.
            Get names of all level tile maps.
            Store names in maps.json example format.
            Write to maps.json file

            Section 2:
            Make maps directory.
            In the maps directory create specified amounts of level directories.

            Section 2 Example:
            json_project -f 100
            */

            if(!Directory.Exists(@"./maps")) Directory.CreateDirectory(@".maps");

            if(Int32.Parse()){ for (int i = 0; i < Int32.Parse(args[0]); i++){}
        }
    }
}
