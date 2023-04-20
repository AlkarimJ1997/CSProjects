namespace WarriorFight
{
    public static class Program
    {
        public static void Main()
        {
            Warrior thor = new Warrior("Thor", 100, 26, 10);
            MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 10, 50);
            
            Battle.StartFight(thor, loki);
        }
    }
}