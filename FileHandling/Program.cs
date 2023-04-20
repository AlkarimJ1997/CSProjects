using System.Text;

namespace FileHandling
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            #region FileHandling

            DirectoryInfo currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            DirectoryInfo myDirectory = new DirectoryInfo("C:\\CSProjects\\FileHandling");

            // Get path of directory
            Console.WriteLine(myDirectory.FullName);
            Console.WriteLine(myDirectory.Name);
            Console.WriteLine(myDirectory.Parent);
            Console.WriteLine(myDirectory.Attributes);
            Console.WriteLine(myDirectory.CreationTime);

            // Create a directory
            DirectoryInfo dataDirectory = myDirectory.CreateSubdirectory("Data");
            dataDirectory.Create();

            string[] customers = { "John Smith", "Mary Smith", "Peter Smith" };
            string filePath = Path.Combine(dataDirectory.FullName, "customers.txt");

            // Write to a file
            File.WriteAllLines(filePath, customers);

            // Read from a file
            foreach (var customer in File.ReadAllLines(filePath)) Console.WriteLine(customer);
            Console.WriteLine("--------------------");

            // Get files in a directory
            DirectoryInfo myDataDirectory = new DirectoryInfo("C:\\CSProjects\\FileHandling\\Data");
            FileInfo[] files = myDataDirectory.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine($"Matches : {files.Length}");
            foreach (var file in files) Console.WriteLine($"{file.Name} : {file.Length} bytes");

            #endregion

            #region FileStreams

            string textFilePath = "C:\\CSProjects\\FileHandling\\Data\\text.txt";
            string randomString = "This is a random string";
            FileStream fs = File.Open(textFilePath, FileMode.Create);

            // String to Byte Array for writing
            byte[] randomStringBytes = Encoding.UTF8.GetBytes(randomString);
            byte[] fileData = new byte[randomStringBytes.Length];
            fs.Write(randomStringBytes, 0, randomStringBytes.Length);

            // Move back to the start of the file
            fs.Position = 0;

            // File Data
            for (var i = 0; i < fileData.Length; i++) fileData[i] = (byte)fs.ReadByte();
            Console.WriteLine(Encoding.UTF8.GetString(fileData));

            // Close the file stream
            fs.Close();

            Console.WriteLine("--------------------");

            #endregion

            #region StreamWriter/StreamReader (best for strings)

            string textFilePath2 = "C:\\CSProjects\\FileHandling\\Data\\text2.txt";
            StreamWriter sw = new StreamWriter(textFilePath2);

            // Write to file
            sw.Write("This is random text");
            sw.WriteLine("sentence.");
            sw.WriteLine("This is another sentence.");

            // Close the stream writer
            sw.Close();

            // Read from file
            StreamReader sr = new StreamReader(textFilePath2);
            Console.WriteLine($"Peek : {(char)sr.Peek()}");
            Console.WriteLine($"First line : {sr.ReadLine()}");
            Console.WriteLine($"Entire file : {sr.ReadToEnd()}");
            
            // Close the stream reader
            sr.Close();

            #endregion
            
            #region Binary Data Handling
            
            string binaryFilePath = "C:\\CSProjects\\FileHandling\\Data\\text3.dat";
            FileInfo datFile = new FileInfo(binaryFilePath);
            
            // Write to file
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());
            bw.Write(123);
            bw.Write("This is a string");
            bw.Write(true);
            
            // Close the binary writer
            bw.Close();
            
            // Read from file
            BinaryReader br = new BinaryReader(datFile.OpenRead());
            
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadBoolean());
            
            // Close the binary reader
            br.Close();

            #endregion
        }
    }
}