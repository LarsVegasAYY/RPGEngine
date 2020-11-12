using System;
using System.Collections.Generic;
using System.Text;

namespace RPGEngine.GameObjects.Items.Armor
{
    public class Armor:Item
    {
        public int ArmorValue { get; set; }
        public Armor(string name, int armorValue):base(name)
        {
            ArmorValue = armorValue;
        }
    }
}
