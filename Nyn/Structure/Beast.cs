using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nyn
{
    public class Beast : Creature
    {
        public bool isTainted { get; set; }
        public bool isXL { get; set; }
        public override string ToString()
        {
            return "Name: " + Name + ", Creature Type: " + nameof(Beast) + ", Faction: " + Faction + ", Attack Points:" + AttackPoints + ", Health Points:" + HealthPoints + ", isXL:" + isXL + ", isTainted:" + isTainted;
        }
    }
}