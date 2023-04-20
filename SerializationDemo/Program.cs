using System.Text.Json;
using System.Xml.Serialization;

namespace SerializationDemo
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            #region JsonSerialize

            Animal? bowser = new Animal("Bowser", 45, 25, 1);
            string json = JsonSerializer.Serialize(bowser);

            File.WriteAllText("AnimalData.json", json);

            // Deleting data
            bowser = null;
            json = File.ReadAllText("AnimalData.json");
            bowser = JsonSerializer.Deserialize<Animal>(json);

            Console.WriteLine(bowser?.ToString());

            if (bowser != null) bowser.Weight = 50;

            #endregion

            #region XMLSerialize

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Animal));

            using TextWriter tw = new StreamWriter("AnimalData.xml");
            xmlSerializer.Serialize(tw, bowser);

            // Close the stream
            tw.Close();

            // Deserializing
            bowser = null;
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader("AnimalData.xml");

            object? obj = deserializer.Deserialize(reader);
            if (obj != null) bowser = (Animal)obj;
            reader.Close();

            Console.WriteLine(bowser?.ToString());

            #endregion

            #region Serializing Collections

            List<Animal>? animalList = new List<Animal>
            {
                new Animal("Mario", 60, 30, 2),
                new Animal("Luigi", 55, 24, 3),
                new Animal("Yoshi", 40, 20, 4)
            };

            // Serializing
            using Stream fs = new FileStream("AnimalList.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            new XmlSerializer(typeof(List<Animal>)).Serialize(fs, animalList);
            
            // Closing the stream
            fs.Close();
            
            // Deserializing
            animalList = null;
            using FileStream fs2 = File.OpenRead("AnimalList.xml");
            animalList = (List<Animal>)new XmlSerializer(typeof(List<Animal>)).Deserialize(fs2)!;
            
            foreach (var animal in animalList) Console.WriteLine(animal.ToString());
            
            // Closing the stream
            fs2.Close();

            #endregion
        }
    }
}