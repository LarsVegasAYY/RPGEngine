using RPGEngine.GameObjects.Environment.Entity.Characters;
using RPGEngine.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Schema;

namespace RPGEngine
{
    public class Worldspace
    {
        private static Worldspace _instance;
        public int MaxX = 50;
        public int MaxY = 50;
        public Tile[,] Space { get; set; }
        public static Worldspace Instance { get { if (_instance == null) _instance = new Worldspace();return _instance; } }
        private Worldspace()
        {
            Space = new Tile[MaxX, MaxY];
        }

    }
}
