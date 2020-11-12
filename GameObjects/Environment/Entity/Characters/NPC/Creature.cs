using RPGEngine.Tools;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RPGEngine.GameObjects.Environment.Entity.Characters.NPC
{
    public abstract class Creature:Character
    {
        public Creature(Position position, string name):base(position, name)
        {

        }
    }
}
