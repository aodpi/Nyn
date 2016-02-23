using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nyn
{
    public class Human : Creature
    {

        public bool hasSwift { get; set; }
        public override string ToString()
        {
            return "Name: " + Name + ", Creature Type: " + nameof(Human) + ", Faction: " + Faction + ", Attack Points:" + AttackPoints + ", Health Points:" + HealthPoints + ", Has Swift:" + hasSwift;
        }
    }
}