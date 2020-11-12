using RPGEngine.GameObjects.Environment.Entity.Characters;
using RPGEngine.GameObjects.Environment.Entity.Characters.PC;
using RPGEngine.Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGEngine
{
    public class Game
    {
        public string Name { get; set; }
        public ItemList ItemList { get; set; }
        public Player Player { get; set; }
        public Worldspace WorldSpace { get; private set; }


        public Game(string name, string playerName)
        {
            Name = name;
            Player = new Player(playerName);
            ItemList = new ItemList();
            WorldSpace = Worldspace.Instance;
        }
    }
}
