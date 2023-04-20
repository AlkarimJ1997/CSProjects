using System.Collections;

namespace LINQDemo
{
    public static class Program
    {
        // ------ FUNCTIONS ------ //

        private static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

            var gt20 = from n in nums
                where n > 20
                orderby n
                select n;

            var result = gt20.ToArray();

            foreach (var n in result) Console.WriteLine(n);

            return result;
        }

        // ------ END OF FUNCTIONS ------ //
        public static void Main(string[] args)
        {
            // LINQ - Language Integrated Query
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Snoopy", "Lassie" };

            var dogsWithSpaces = from dog in dogs
                where dog.Contains(' ')
                orderby dog descending
                select dog;

            Console.WriteLine(string.Join(", ", dogsWithSpaces));
            Console.WriteLine("--------------------");

            int[] intArray = QueryIntArray();
            Console.WriteLine(string.Join(", ", intArray));
            Console.WriteLine("--------------------");

            // LINQ with Classes
            ArrayList animalList = new ArrayList()
            {
                new Animal() { Name = "German Shepherd", Height = 25, Weight = 77, AnimalId = 1 },
                new Animal() { Name = "Chihuahua", Height = 7, Weight = 4.4, AnimalId = 2 },
                new Animal() { Name = "Saint Bernard", Height = 30, Weight = 200, AnimalId = 3 },
                new Animal() { Name = "Pug", Height = 12, Weight = 6, AnimalId = 1 },
                new Animal() { Name = "Beagle", Height = 15, Weight = 23, AnimalId = 2 }
            };

            Owner[] owners = new[]
            {
                new Owner() { Name = "Doug Parks", OwnerId = 1 },
                new Owner() { Name = "Sally Smith", OwnerId = 2 },
                new Owner() { Name = "Paul Brooks", OwnerId = 3 }
            };

            var famAnimalEnum = animalList.OfType<Animal>();
            var bigDogs = from dog in famAnimalEnum
                where dog.Weight > 70 && dog.Height > 25
                orderby dog.Name
                select dog;

            var nameHeight = from a in animalList.OfType<Animal>()
                select new { a.Name, a.Height };
            Array arrNameHeight = nameHeight.ToArray();
            
            var innerJoin = from a in animalList.OfType<Animal>()
                join o in owners on a.AnimalId equals o.OwnerId
                orderby o.Name
                select new { OwnerName = o.Name, AnimalName = a.Name };
            
            foreach(var i in innerJoin) Console.WriteLine(i.ToString());
            
            var groupJoin = from o in owners
                join a in animalList.OfType<Animal>() on o.OwnerId equals a.AnimalId into oa
                orderby o.OwnerId
                select new { OwnerName = o.Name, Animals = oa };
            
            foreach(var i in groupJoin)
            {
                Console.Write($"{i.OwnerName} has {i.Animals.Count()} animals ~ ");
                foreach(var j in i.Animals) Console.Write($"{j.Name}, ");
                Console.WriteLine();
            }

            Console.WriteLine(string.Join(", ", bigDogs));
        }
    }
}