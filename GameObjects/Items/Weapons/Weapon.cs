using System;
using System.Collections.Generic;
using System.Text;

namespace RPGEngine.GameObjects.Items.Weapons
{
    public class Weapon:Item
    {
        public int Damage { get; set; }
        public Weapon(string name, int damage):base(name)
        {
            Damage = damage;
        }
    }
}
