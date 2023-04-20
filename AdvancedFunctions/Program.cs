namespace AdvancedFunctions
{
    public static class Program
    {
        // ------ Functions ------

        private delegate double DoubleIt(double val);

        // ------ END OF FUNCTIONS ------
        public static void Main(string[] args)
        {
            DoubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");

            // Where
            var numList = new List<int>() { 1, 9, 2, 6, 3 };
            var evenList = numList.Where(x => x % 2 == 0);

            Console.WriteLine(string.Join(", ", evenList));

            List<int> flipList = Enumerable.Range(1, 100).Select(x => new Random().Next(1, 3)).ToList();
            Console.WriteLine($"Heads: {flipList.Count(x => x == 1)}");
            Console.WriteLine($"Tails: {flipList.Count(x => x == 2)}");

            Console.WriteLine("--------------------");

            var nameList = new List<string> { "John", "Jane", "Joe", "Jill", "Sally", "Sue" };
            var sNameList = nameList.Where(name => name.StartsWith("S"));
            
            Console.WriteLine(string.Join(", ", sNameList));
            Console.WriteLine("--------------------");
            
            // Select
            var oneToTen = Enumerable.Range(1, 10).ToList();
            var squaredList = oneToTen.Select(x => x * x);
            Console.WriteLine(string.Join(", ", squaredList));
            
            // Zip
            var listOne = new List<int> { 1, 3, 4 };
            var listTwo = new List<int> { 4, 6, 8 };
            var sumList = listOne.Zip(listTwo, (x, y) => x + y);
            Console.WriteLine(string.Join(", ", sumList));
            
            // Aggregate
            var numList2 = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Sum {numList2.Aggregate((x, y) => x + y)}");
            Console.WriteLine($"Product {numList2.Aggregate((x, y) => x * y)}");
            Console.WriteLine($"Max {numList2.Aggregate((x, y) => x > y ? x : y)}");
            Console.WriteLine($"Min {numList2.Aggregate((x, y) => x < y ? x : y)}");
            
            // All & Any
            Console.WriteLine($"All > 3: {numList2.All(x => x > 3)}");
            Console.WriteLine($"Any > 3: {numList2.Any(x => x > 3)}");
            
            // Distinct (kind of like Set in Python)
            var dupList = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", dupList.Distinct()));
            
            // Except & Intersect
            var numList3 = new List<int> { 3 };
            Console.WriteLine(string.Join(", ", numList2.Except(numList3)));
            Console.WriteLine(string.Join(", ", numList2.Intersect(numList3)));
        }
    }
}