namespace WarriorFight;

public class MagicWarrior : Warrior
{
    private int _teleportChance = 0;
    private CanTeleport _teleportType = new CanTeleport();

    public MagicWarrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0,
        int teleportChance = 0) : base(name, health, attackMax, blockMax)
    {
        _teleportChance = teleportChance;
    }

    public override double Block()
    {
        Random rnd = new Random();
        int randomDodge = rnd.Next(1, 100);

        if (randomDodge >= _teleportChance) return base.Block();
        
        Console.WriteLine($"{Name} { _teleportType.Teleport()}");
        return 10000;
    }
}