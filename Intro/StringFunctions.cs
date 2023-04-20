namespace Intro;

public static class StringFunctions
{
    public static void Run()
    {
        const string randString = "This is a string";
        
        Console.WriteLine($"Length: {randString.Length}");
        Console.WriteLine($"ToUpper: {randString.ToUpper()}");
        Console.WriteLine($"ToLower: {randString.ToLower()}");
        Console.WriteLine($"Contains: {randString.Contains("is")}");
        Console.WriteLine($"StartsWith: {randString.StartsWith("This")}");
        Console.WriteLine($"EndsWith: {randString.EndsWith("string")}");
        Console.WriteLine($"IndexOf: {randString.IndexOf("is", StringComparison.InvariantCulture)}");
        Console.WriteLine($"Remove: {randString.Remove(0, 2)}");
        Console.WriteLine($"Replace: {randString.Replace("string", "sentence")}");
        Console.WriteLine($"Insert: {randString.Insert(0, "Hey, ")}");
        Console.WriteLine($"Compare: {string.Compare("A", "B", StringComparison.Ordinal)}");
        Console.WriteLine($"Compare A=a: {string.Compare("A", "a", StringComparison.OrdinalIgnoreCase)}");
        
        /*
         * Escape Characters
         * \n - New Line
         * \t - Tab
         * \\ - Backslash
         * \" - Double Quote
         * \' - Single Quote
         */
    }
}