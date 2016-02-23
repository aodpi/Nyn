using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyn
{
    public class NynRealm
    {
        /// <summary>
        /// Backing field for the actual property.
        /// </summary>
        private List<Creature> _database;

        public NynRealm()
        {
            DataBase = new List<Creature>();
        }

        public Creature this[int key]
        {
            get
            {
                return DataBase[key];
            }
            set
            {
                DataBase[key] = value;
            }
        }
        /// <summary>
        /// Hold all creatures in a <see cref="List{Creature}"/>
        /// </summary>
        private List<Creature> DataBase
        {
            get
            {
                return _database;
            }

            set
            {
                _database = value;
            }
        }

        public void AddCreature(Creature newCreature)
        {
            DataBase.Add(newCreature);
        }

        public void RemoveCreature(string name)
        {
            Creature x = new Creature() { Name = name };
            if (DataBase.Contains(x))
            {
                DataBase.Remove(x);
            }
            else
            {
                Console.WriteLine("Nu exista.");
            }
            
        }

        public void RemoveRange(int from, int to)
        {
            from--;
            DataBase.RemoveRange(from, to - from);
        }
        public enum SortBy
        {
            Name,
            AttackPoints,
            HealthPoints,
        }
        public void SortNyn(SortBy by)
        {
            switch (by)
            {
                case SortBy.Name:
                    DataBase = DataBase.OrderBy(a => a.Name).ToList();
                    break;
                case SortBy.AttackPoints:
                    DataBase = DataBase.OrderBy(a => a.AttackPoints).ToList();
                    break;
                case SortBy.HealthPoints:
                    DataBase = DataBase.OrderBy(a => a.HealthPoints).ToList();
                    break;
                default:
                    break;
            }
        }
        public void ShowAllNynCreatures()
        {
            if (DataBase.Count != 0)
            {
                foreach (Creature item in DataBase)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No one in Nyn");
                return;
            }
        }
    }
}
