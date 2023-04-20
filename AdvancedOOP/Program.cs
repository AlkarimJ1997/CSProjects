namespace AdvancedOOP
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            AnimalFarm myAnimals = new AnimalFarm();

            myAnimals[0] = new Animal("Wilbur");
            myAnimals[1] = new Animal("Charlotte");
            myAnimals[2] = new Animal("Templeton");
            myAnimals[3] = new Animal("Gander");
            
            foreach (Animal a in myAnimals) Console.WriteLine(a.Name);
            
            Console.WriteLine("---------------------------------");

            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);
            Box box3 = box1 + box2;
            
            Console.WriteLine(box3.ToString());
            Console.WriteLine((int)box3);

            Box box4 = (Box)4;
            Console.WriteLine(box4.ToString());
            
            Console.WriteLine("---------------------------------");
            
            // Anonymous types
            var toy = new { Name = "Teddy Bear", Price = 19.95 };
            Console.WriteLine($"{toy.Name} costs {toy.Price}");
            
            var toyArr = new[]
            {
                new { Name = "Teddy Bear", Price = 19.95 },
                new { Name = "Lego", Price = 29.95 }
            };
            
            Console.WriteLine(string.Join("\n", toyArr.Select(t => $"{t.Name} costs {t.Price}")));
        }
    }
}