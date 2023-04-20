namespace WarriorFight;

public class Battle
{
    public static void StartFight(Warrior warrior1, Warrior warrior2)
    {
        while (true)
        {
            if (GetAttackResult(warrior1, warrior2) == "Game Over")
            {
                Console.WriteLine("Game Over");
                break;
            }

            if (GetAttackResult(warrior2, warrior1) == "Game Over")
            {
                Console.WriteLine("Game Over");
                break;
            }
        }
    }

    public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
    {
        double warriorAAttack = warriorA.Attack();
        double warriorBBlock = warriorB.Block();
        double damageToWarriorB = warriorAAttack - warriorBBlock;

        damageToWarriorB = (damageToWarriorB < 0) ? 0 : damageToWarriorB;
        warriorB.Health = warriorB.Health - damageToWarriorB;

        Console.WriteLine($"{warriorA.Name} attacks {warriorB.Name} and deals {damageToWarriorB} damage");
        Console.WriteLine($"{warriorB.Name} has {warriorB.Health} health\n");

        if (warriorB.Health > 0) return "Fight Again";

        Console.WriteLine($"{warriorB.Name} has died and {warriorA.Name} is victorious\n");
        return "Game Over";
    }
}