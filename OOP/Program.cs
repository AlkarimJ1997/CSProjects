namespace OOP
{
    public static class Program
    {
        // ---- Structs ----

        private struct Rectangle
        {
            public double Length;
            public double Width;

            public Rectangle(double l = 1, double w = 1)
            {
                Length = l;
                Width = w;
            }

            public double Area()
            {
                return Length * Width;
            }
        }

        // ---- END OF Structs ----
        public static void Main(string[] args)
        {
            Rectangle rect1;
            Rectangle rect2 = new Rectangle(100, 40);

            rect1.Length = 200;
            rect1.Width = 50;

            Console.WriteLine($"Area of rect1 is {rect1.Area()}");
            Console.WriteLine($"Area of rect2 is {rect2.Area()}");
            Console.WriteLine("--------------------------------");

            //Animal fox = new Animal() { Name = "Red", Sound = "Raw"};
            Animal whiskers = new Animal() { Name = "Whiskers", Sound = "Meow" };
            Dog grover = new Dog() { Name = "Grover", Sound = "Woof", Sound2 = "Gr" };

            grover.Sound = "Wooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIdInfo(12345, "Sally Smith");
            grover.SetAnimalIdInfo(12346, "Paul Brown");

            whiskers.GetAnimalIdInfo();
            grover.GetAnimalIdInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine($"Is my animal healthy : {getHealth.HealthyWeight(11, 46)}");

            Animal monkey = new Animal() { Name = "Happy", Sound = "Eee" };
            Animal spot = new Dog() { Name = "Spot", Sound = "Woooofff", Sound2 = "Geeeerrrr"};
            
            spot.MakeSound();

            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Area of Rectangle: {ShapeMath.GetArea("Rectangle", 5, 6)}");
            Console.WriteLine("--------------------------------");

            // Nullable Types
            int? randNum = null;

            if (randNum == null) { Console.WriteLine("randNum is null"); }
            if (!randNum.HasValue) { Console.WriteLine("randNum is null"); }

            Console.WriteLine("--------------------------------");
        }
    }
}