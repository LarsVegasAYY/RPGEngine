using RPGEngine.GameObjects.Effects;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RPGEngine.GameObjects.Items.Consumables
{
    public class Consumable:Item
    {
        public Effect Effect { get; private set; }
        public int Duration { get; set; }
        public Consumable(string name, int duration):base(name)
        {
            Duration = duration;
        }
        public Consumable(string name, int duration, string effectName, PropertyInfo propertyInfo, int flatModifier = 0, int percentageModifier = 0):base(name)
        {
            Duration = duration;
            AddEffect(effectName, propertyInfo, flatModifier, percentageModifier);
        }
        public void AddEffect(string name, PropertyInfo propertyInfo, int flatModifier = 0, int percentageModifier = 0) 
        {
            Effect = new Effect(name, propertyInfo, flatModifier, percentageModifier);
        }
    }
}
