using RPGEngine.GameObjects.Environment.Entity.Characters;
using RPGEngine.GameObjects.Environment.Entity.Characters.NPC;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGEngine.GameObjects.Items.Spells
{
    public class Spell:Item
    {
        public Spell(string name):base(name)
        {

        }
        public virtual void CastOverWorldSpell(Creature target, Character owner = null) {} 
    }
}
