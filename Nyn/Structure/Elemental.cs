using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nyn
{
    public class Elemental : Creature
    {

        public Faction GiftedElement { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", Creature Type: " + nameof(Human) + ", Faction: " + Faction + ", Attack Points:" + AttackPoints + ", Health Points:" + HealthPoints + ", Gifted Element:" + GiftedElement;
        }
    }
}