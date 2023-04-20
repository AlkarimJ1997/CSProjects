namespace OOPContinued
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach (Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine($"{s.Name} Area : {s.Area():F2}");

                if (s is Circle testCircle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }
                else
                {
                    Console.WriteLine("This isn't a Circle");
                }
            }
            
            // Polymorphism
            object circle = new Circle(4);
            Circle circle2 = (Circle)circle;
            
            Console.WriteLine("------------------");
            Console.WriteLine($"The {circle2.Name} Area is {circle2.Area():F2}");
        }
    }
}