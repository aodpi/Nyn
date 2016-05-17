using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nyn
{
    public class Creature
    {
        /// <summary>
        /// Faction that represents current creature.
        /// </summary>
        public Faction Faction { get; set; }

        /// <summary>
        /// Hitpoints of current creature.
        /// </summary>
        public int HealthPoints { get; set; }

        /// <summary>
        /// The damage current creature deals.
        /// </summary>
        public int AttackPoints { get; set; }

        /// <summary>
        /// Name of current creature
        /// </summary>
        public string Name { get; set; }
        public override bool Equals(object obj)
        {
            return Name.Equals(((Creature)obj).Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}