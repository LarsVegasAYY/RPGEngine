using RPGEngine.GameObjects.Environment.Entity.StaticEntity;
using RPGEngine.GameObjects.Items;
using RPGEngine.GameObjects.Items.Armor;
using RPGEngine.GameObjects.Items.Consumables;
using RPGEngine.GameObjects.Items.Weapons;
using RPGEngine.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace RPGEngine.GameObjects.Environment.Entity.Characters.PC
{
    public class Player: Character
    {
        //inventory
        public List<Item> Inventory { get; set; }

        
        //potion bar
        public List<Consumable> ConsumableBar { get; private set; }
        public int ConsumableBarSize { get; set; }
        //spellbook

        public Player(Position position, string name) :base(position, name)
        {

        }
        public Player(string name):base(new Position(0, 0), name)
        {

        }


        public void PickUpItem(Container container, Item item)
        {
            Inventory.Add(item);
            container.Inventory.Remove(item);
        }


        public void AddConsumableToBar(Consumable consumable)
        {
            if(ConsumableBar.Count() < ConsumableBarSize)
            {
                ConsumableBar.Add(consumable);
            }
        }
    }
}
