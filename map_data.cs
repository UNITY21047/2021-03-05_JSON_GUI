using System;

namespace _2021_03_05_JSON_GUI
{
    public class map_data
    {
        string tileset {get; set;}
        string tileset_image {get; set;}
        string tilemap {get; set;}

        public map_data(string tileset, string tileset_image, string tilemap)
        {
            this.tileset = tileset;
            this.tileset_image = tileset_image;
            this.tilemap = tilemap;
        }
    }
}