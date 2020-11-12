using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RPGEngine.GameObjects.Effects
{
    public class Effect
    {
        public string Name { get; set; }
        public PropertyInfo TargetProperty { get; set; }
        public int FlatModifier { get; set; }
        public int PercentageModifier { get; set; }

        public Effect(string name, PropertyInfo target, int flatModifier = 0, int percentageModifier = 0)
        {
            Name = name;
            TargetProperty = target;
            FlatModifier = flatModifier;
            PercentageModifier = percentageModifier;
        }
    }
}
