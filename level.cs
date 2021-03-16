using System.Collections.Generic;

namespace _2021_03_05_JSON_GUI
{
    public class level
    {
        /*
        Schema:
        {
        //variable_name
            //Entries in Dictionary
            "level_1":
            {   
                [
                    "tileset":"...",
                    "tileset_image":"...",
                    "tilemap":"..."
                ],
                [
                    ...
                ],
                ...
            },
            ...
        }
        */
        public Dictionary<string, IList<map_data>> levels = new Dictionary<string, IList<map_data>>();
    }
}