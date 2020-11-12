using RPGEngine.GameObjects.Items.Armor;
using RPGEngine.GameObjects.Items.Consumables;
using RPGEngine.GameObjects.Items.Weapons;
using RPGEngine.Tools;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RPGEngine.GameObjects.Environment.Entity.Characters
{
    public abstract class Character:Entity
    {
        //base
        public string Name { get; set; }
        public Worldspace worldspace { get; set; }

        //combat
        public int HitPoints { get; set; }
        public int MaxHitpoints { get; set; }

        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }

        //movement
        public Path? Route { get; set; }
        //public double MovementSpeed { get; set; } // 1/10 tile per MovementSpeed


        public Character(Position position, string name):base(position)
        {
            worldspace = Worldspace.Instance;
        }
        public void Attack(Character target)
        {
            //check if target pos is 1 tile away
            if((Position.X == target.Position.X+1 || Position.X == target.Position.X - 1 || Position.X == target.Position.X)&&(Position.Y == target.Position.Y+1 || Position.Y == target.Position.Y-1 || Position.Y == target.Position.Y)) 
            {
                //check if not diagonal and not itself
                if(target.Position.X != Position.X ^ target.Position.Y != Position.Y)
                {

                }
            }
        }

        public void Move() 
        {
            for (int i = 0; i < Route.Route.Count; i++)
            {
                Position oldPos = Position;
                Position newPos = Route.Next();
                Position = newPos;

                worldspace.Space[oldPos.X, oldPos.Y].TopLayer = null;
                worldspace.Space[newPos.X, newPos.Y].TopLayer = this;
            }
            Route = null;
        }
        public void SetRoute(Position destination) 
        {
            Route = PathFind(destination);
        }
        public Path PathFind(Position destination) 
        {
            //not properly implemented, used simple solution instead
            List<Position> returnRoute = new List<Position>();
            int x = destination.X - this.Position.X;
            int y = destination.Y - this.Position.Y;


            if (x >= 0)
            {
                for(int i = this.Position.X + 1; i <= destination.X; i++)
                {
                    returnRoute.Add(new Position(i, y));
                }
            }
            else
            {
                for(int i = this.Position.X - 1; i >= destination.X; i--)
                {
                    returnRoute.Add(new Position(i, y));
                }
            }
            if (y >= 0)
            {
                for(int i = this.Position.Y + 1; i <= destination.Y; i++)
                {
                    returnRoute.Add(new Position(x, i));
                }
            }
            else
            {
                for(int i = this.Position.Y - 1; i >= destination.Y; i--)
                {
                    returnRoute.Add(new Position(x, i));
                }
            }

            return new Path(returnRoute);
        }

        //combat actions
        public void SwingWeapon(Character owner, Character target, Consumable consumable) 
        {
            target.HitPoints -= (owner.Weapon.Damage - target.Armor.ArmorValue)>0? (owner.Weapon.Damage - target.Armor.ArmorValue) :1;
        }
        public void UseConsumable(Character owner, Character target, Consumable consumable) 
        {
            owner.HitPoints += consumable.Effect.FlatModifier;
        }
    }
}
