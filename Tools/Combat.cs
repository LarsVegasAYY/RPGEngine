using RPGEngine.GameObjects.Environment.Entity.Characters;
using RPGEngine.GameObjects.Items.Consumables;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RPGEngine.Tools
{
    public class Combat
    {
        public int Turn { get; set; }
        public Character Attacker { get; set; }
        public Character Defender { get; set; }
        public Character WhosTurn { get { if (Turn % 2 == 1) return Attacker; else return Defender; } }
        public Character Victor { get; set; }
        public Combat(Character attacker, Character defender)
        {
            Turn = 1;
            Attacker = attacker;
            Defender = defender;
        }

        public bool CombatPhase(Character attacker, Character defender, CombatAction combatAction, Consumable consumable = null)
        {
            bool combatOver = false;

            combatAction(attacker, defender, consumable);

            if (defender.HitPoints <= 0)
            {
                combatOver = true;
                Victor = attacker;
            }
            Turn++;
            return combatOver;
        }
    }
}
