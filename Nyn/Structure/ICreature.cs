namespace Nyn
{
    public interface ICreature
    {
        int AttackPoints { get; set; }
        Faction Faction { get; set; }
        int HealthPoints { get; set; }
        string Name { get; set; }

        bool Equals(object obj);
    }
}