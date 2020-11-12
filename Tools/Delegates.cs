using RPGEngine.GameObjects.Environment.Entity.Characters;
using RPGEngine.GameObjects.Items.Consumables;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGEngine.Tools
{
    public delegate void CombatAction(Character owner, Character target, Consumable consumable);
}
