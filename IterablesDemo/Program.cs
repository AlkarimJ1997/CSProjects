using System.Collections;

namespace IterablesDemo
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            #region ArrayList Code

            ArrayList arrList = new ArrayList();
            ArrayList arrList2 = new ArrayList();

            arrList.Add("Bob");
            arrList.Add(40);

            Console.WriteLine($"Count: {arrList.Count}");
            Console.WriteLine($"Capacity: {arrList.Capacity}");
            Console.WriteLine($"-------------------------");

            arrList2.AddRange(new object[] { "Sue", "Mary", "Tom" });
            arrList.AddRange(arrList2);

            // Sorting and reverse
            //arrList2.Sort();
            arrList2.Reverse();

            arrList.Insert(1, "Turkey");
            //arrList2.RemoveAt(0);
            //arrList2.RemoveRange(0, 2);

            // Finding a match
            Console.WriteLine($"Turkey is at index: {arrList2.IndexOf("Turkey")}");

            // Printing out the array
            Console.WriteLine(string.Join(", ", arrList2.Cast<object>()));

            // Conversion to String Array
            string[] stringArray = (string[])arrList2.ToArray(typeof(string));

            // Conversion to Array List
            ArrayList arrList3 = new ArrayList(stringArray);

            #endregion

            #region Dictionary Code

            Dictionary<string, string> superHeroes = new Dictionary<string, string>
            {
                { "Clark Kent", "Superman" },
                { "Bruce Wayne", "Batman" },
                { "Barry Allen", "Flash" }
            };

            // Removing and adding an item
            superHeroes.Remove("Barry Allen");
            superHeroes.Add("Hal Jordan", "Green Lantern");

            Console.WriteLine($"Count: {superHeroes.Count}");

            // Check if a key exists
            Console.WriteLine($"Clark Kent exists: {superHeroes.ContainsKey("Clark Kent")}");

            // Check if a value exists
            Console.WriteLine($"Superman exists: {superHeroes.ContainsValue("Superman")}");

            // Cycle through key value pairs
            foreach (KeyValuePair<string, string> item in superHeroes)
            {
                Console.WriteLine($"{item.Key} is {item.Value}");
            }

            // Cycle through keys
            foreach (string key in superHeroes.Keys)
            {
                Console.WriteLine(key);
            }

            // Cycle through values
            foreach (string value in superHeroes.Values)
            {
                Console.WriteLine(value);
            }

            // Syntactic Sugar
            Console.WriteLine(string.Join(", ", superHeroes.Select(x => $"{x.Key} : {x.Value}")));

            // Clear the dictionary
            superHeroes.Clear();

            #endregion

            #region Queues Code

            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Does item exist in queue
            Console.WriteLine($"Does 1 exist in queue: {queue.Contains(1)}");

            // Peek at the first item
            Console.WriteLine($"First item: {queue.Peek()}");

            // Remove the first item
            Console.WriteLine($"Removed: {queue.Dequeue()}");

            // Print out the queue
            Console.WriteLine(string.Join(", ", queue.Cast<object>()));

            // Clear the queue
            queue.Clear();

            // Separators
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");

            #endregion

            #region Stack Code

            Stack stack = new Stack(new[] { 0 });

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Does item exist in stack
            Console.WriteLine($"Does 1 exist in stack: {stack.Contains(1)}");

            // Peek at the first item
            Console.WriteLine($"First item: {stack.Peek()}");

            // Remove the first item
            Console.WriteLine($"Removed: {stack.Pop()}");

            // Print out the stack
            Console.WriteLine(string.Join(", ", stack.Cast<object>()));

            // Clear the stack
            stack.Clear();

            // Separators
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");

            #endregion
        }
    }
}