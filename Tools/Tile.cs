using RPGEngine.GameObjects.Environment.Entity;
using RPGEngine.GameObjects.Environment.Terrain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGEngine.Tools
{
    public class Tile
    {
        public Terrain BottomLayer { get; set; }
        public Entity TopLayer { get; set; }
        public Tile(Terrain bottomLayer, Entity topLayer)
        {
            BottomLayer = bottomLayer;
            TopLayer = topLayer;
        }
        public Tile() { }
    }
}
