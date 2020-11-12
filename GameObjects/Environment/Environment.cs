using RPGEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;


namespace RPGEngine.GameObjects.Environment
{
    public abstract class Environment:GameObject 
    {
        public Position Position { get; set; }
        public Environment(Position position)
        {
            Position = position;
        }
    }
}
