namespace Intro;

public static class Functions
{
    // ------ FUNCTIONS ------

    private static void SayHello()
    {
        string? name = "";
        Console.Write("What is your name? ");
        name = Console.ReadLine();
        Console.WriteLine($"Hello {name}!");
    }

    // Default parameters
    private static double GetSum(double x = 1, double y = 1)
    {
        return x + y;
    }

    // Out parameters
    private static void DoubleIt(int x, out int solution)
    {
        solution = x * 2;
    }

    // Pass by reference
    private static void Swap(ref int x, ref int y)
    {
        (x, y) = (y, x);
    }
    
    // Variable number of arguments
    private static double GetSumMore(params double[] numbers)
    {
        return numbers.Sum();
    }

    // Named parameters : PrintInfo(zipCode: 12345, name: "John Doe");
    private static void PrintInfo(string name, int zipCode)
    {
        Console.WriteLine($"{name} lives in {zipCode}");
    }

    private static double GetSum2(double x = 1, double y = 1)
    {
        return x + y;
    }
    
    private static double GetSum2(string x = "1", string y = "1")
    {
        return double.Parse(x) + double.Parse(y);
    }

    // ------ END OF FUNCTIONS ------
    public static void Run()
    {
        /*
         * Functions are composed with the following:
         * <ACCESS SPECIFIER> <RETURN TYPE> <NAME>(<PARAMETERS>)
         * {
         *     <BODY>
         * }
         *
         * Access Specifier:
         *   public - Accessible from anywhere
         *   private - Accessible only from within the class
         *   protected - Accessible only from within the class and derived classes
         *
         */
        Console.WriteLine(GetSum2(3, 4));
        Console.WriteLine(GetSum2("3", "4"));
    }
}