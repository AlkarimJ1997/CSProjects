namespace GenericsDemo
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            List<int> numList = new List<int>() { 24 };

            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Sally" });
            animalList.Add(new Animal() { Name = "Bobby" });

            animalList.Insert(1, new Animal() { Name = "Steve" });
            animalList.RemoveAt(1);
            
            Console.WriteLine($"Num of Animals : {animalList.Count}");
            Console.WriteLine(string.Join(", ", animalList.Select(x => x.Name)));
            
            // Generic Demo
            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);
            
            string strX = "5", strB = "4";
            Animal.GetSum<string>(ref strX, ref strB);
            
            Console.WriteLine("----------------------");
            
            Rectangle<int> r1 = new Rectangle<int>(20, 50);
            Rectangle<string> r2 = new Rectangle<string>("20", "50");

            Console.WriteLine(r1.GetArea());
            Console.WriteLine(r2.GetArea());
            Console.WriteLine("----------------------");
            
            // Delegate Demo
            Arithmetic add, sub, addSub;
            
            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;

            Console.WriteLine("Add 6 and 10");
            add(6, 10);
            
            Console.WriteLine("Add & Subtract 10 and 4");
            addSub(10, 4);
        }
        
        // ----- Structs -----

        public struct Rectangle<T>
        {
            private T length { get; set; }
            private T width;
            
            public T Width
            {
                get => width;
                set => width = value;
            }

            public Rectangle(T l, T w)
            {
                length = l;
                width = w;
            }
            
            public string GetArea()
            {
                double dLength = Convert.ToDouble(length);
                double dWidth = Convert.ToDouble(width);
                
                return $"Area : {dLength * dWidth}";
            }
        }

        public delegate void Arithmetic(double x, double y);

        public static void Add(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        
        public static void Subtract(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        // ----- END OF Structs -----
    }
}