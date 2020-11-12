using RPGEngine.GameObjects.Items.Armor;
using RPGEngine.GameObjects.Items.Consumables;
using RPGEngine.GameObjects.Items.Spells;
using RPGEngine.GameObjects.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RPGEngine.Lists
{
    public class ItemList
    {
        public List<Weapon> WeaponList { get; private set; }
        public List<Armor> ArmorList { get; private set; }
        public List<Spell> SpellList { get; private set; }
        public List<Consumable> ConsumableList { get; private set; }
        public ItemList()
        {
            WeaponList = new List<Weapon>();
            ArmorList = new List<Armor>();
            SpellList = new List<Spell>();
            ConsumableList = new List<Consumable>();
        }

        public void AddWeapon(string name, int dmg)
        {
            WeaponList.Add(new Weapon(name, dmg));
        }
        public void AddArmor(string name, int armor)
        {
            ArmorList.Add(new Armor(name, armor));
        }
        public void AddSpell()
        {

        }
        public void AddConsumable(string name, int duration, string effectName, PropertyInfo propertyInfo, int flatModifier, int percentageModifier)
        {
            ConsumableList.Add(new Consumable(name, duration, effectName, propertyInfo, flatModifier, percentageModifier));
        }
    }
}
