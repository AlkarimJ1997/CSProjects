namespace WarriorFight;

public class Warrior
{
    public string Name { get; set; }
    public double Health { get; set; }
    public double AttackMax { get; set; }
    public double BlockMax { get; set; }

    private readonly Random _rnd = new Random();

    public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0)
    {
        Name = name;
        Health = health;
        AttackMax = attackMax;
        BlockMax = blockMax;
    }

    public double Attack()
    {
        return _rnd.Next(1, (int)AttackMax);
    }

    public virtual double Block()
    {
        return _rnd.Next(1, (int)BlockMax);
    }
}