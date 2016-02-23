using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyn
{
    class Program
    {
        static void Main(string[] args)
        {
            NynRealm nyn = new NynRealm();
            int sel = 0;
            asdf:
            Console.Clear();
            ShowMenu();
            sel = int.Parse(Console.ReadLine());
            switch (sel)
            {
                case 1:
                    nyn.AddCreature(ShowTypeMenu());
                    break;
                case 2:
                    Console.WriteLine();
                    nyn.ShowAllNynCreatures();
                    break;
                case 3:
                    Console.WriteLine("Dati numele creaturii:");
                    string name = Console.ReadLine();
                    nyn.RemoveCreature(name);
                    break;
                case 4:
                    Console.WriteLine("Sortare dupa: 1.Nume 2.Attack Points 3.Health Points");
                    int sele = int.Parse(Console.ReadLine());
                    switch (sele)
                    {
                        case 1:
                            nyn.SortNyn(NynRealm.SortBy.Name);
                            break;
                        case 2:
                            nyn.SortNyn(NynRealm.SortBy.AttackPoints);
                            break;
                        case 3:
                            nyn.SortNyn(NynRealm.SortBy.HealthPoints);
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("De la:");
                    int from = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pina la:");
                    int to = int.Parse(Console.ReadLine());
                    nyn.RemoveRange(from, to);
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            goto asdf;
        }

        public static void Populate(Creature input)
        {
            Console.WriteLine("AttackPoints:");
            input.AttackPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("Faction(Nature,Fire,Frost or Shadow): ");
            Faction self;
            Enum.TryParse(Console.ReadLine(), out self);
            input.Faction = self;
            Console.WriteLine("Health Points:");
            input.HealthPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: ");
            input.Name = Console.ReadLine();
        }

        public static Creature ShowTypeMenu()
        {
            Console.Clear();
            Console.Write("1. Human\n2. Wyrm\n3. Beast\n4. Elemental\n5. Giant\n\n");
            int sel = 0;
            sel = int.Parse(Console.ReadLine());
            switch (sel)
            {
                case 1:
                    Human hum = new Human();
                    Populate(hum);
                    Console.WriteLine("Has Swift (true/false): ");
                    hum.hasSwift = bool.Parse(Console.ReadLine());
                    return hum;
                case 2:
                    Wyrm wyrm = new Wyrm();
                    Populate(wyrm);
                    Console.WriteLine("Corrosive Damage: ");
                    wyrm.CorrosiveDamage = int.Parse(Console.ReadLine());
                    return wyrm;
                case 3:
                    Beast bst = new Beast();
                    Populate(bst);
                    Console.WriteLine("isXL: ");
                    bst.isXL = bool.Parse(Console.ReadLine());
                    Console.WriteLine("isTainted: ");
                    bst.isTainted = bool.Parse(Console.ReadLine());
                    return bst;
                case 4:
                    Elemental el = new Elemental();
                    Populate(el);
                    Console.WriteLine("Gifted Element (Nature,Fire,Frost or Shadow): ");
                    Faction f;
                    Enum.TryParse(Console.ReadLine(),out f);
                    el.GiftedElement = f;
                    return el;
                case 5:
                    Giant gt = new Giant();
                    Populate(gt);
                    Console.WriteLine("Infused Element (Nature,Fire,Frost or Shadow): ");
                    Faction ie;
                    Enum.TryParse(Console.ReadLine(), out ie);
                    gt.InfusedElement = ie;
                    return gt;
            }
            return null;
        }
        public static void ShowMenu()
        {
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("\t1.Adauga");
            Console.WriteLine("\t2.Afiseaza");
            Console.WriteLine("\t3.Sterge");
            Console.WriteLine("\t4.Sortare");
            Console.WriteLine("\t5.Sterge rang");
        }
    }
}
