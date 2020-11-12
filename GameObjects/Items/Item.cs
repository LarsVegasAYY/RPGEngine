using System;
using System.Collections.Generic;
using System.Text;

namespace RPGEngine.GameObjects.Items
{
    public abstract class Item:GameObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Item(string name)
        {
            Name = name;
        }
    }
}
