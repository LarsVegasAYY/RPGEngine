using RPGEngine.GameObjects.Items;
using RPGEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGEngine.GameObjects.Environment.Entity.StaticEntity
{
    public abstract class Container:StaticEntity
    {
        public List<Item> Inventory { get; set; }
        public Container(Position position):base(position)
        {

        }
    }
}
