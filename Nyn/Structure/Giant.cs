using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nyn
{
    public class Giant : Creature
    {

        public Faction InfusedElement { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", Creature Type: " + nameof(Human) + ", Faction: " + Faction + ", Attack Points:" + AttackPoints + ", Health Points:" + HealthPoints + ", Infused Element:" + InfusedElement;
        }
    }
}