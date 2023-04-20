using System.Globalization;

namespace Intro;

public static class Variables
{
    public static void Run()
    {
        bool canVote = true;

        Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
        Console.WriteLine("Smallest Integer : {0}", int.MinValue);
        
        Console.WriteLine("Biggest Long : {0}", long.MaxValue);
        Console.WriteLine("Smallest Long : {0}", long.MinValue);

        decimal pi = 3.141592653589793238462643383279M;
        decimal bigNum = 3.00000000000000000000000011M;
        
        Console.WriteLine($"DEC: {pi} + {bigNum} = {pi + bigNum}");
        
        // Variable Conversion
        bool boolFromStr = bool.Parse("true");
        int intFromStr = int.Parse("42");
        double doubleFromStr = double.Parse("3.14");
        
        string strVal = doubleFromStr.ToString(CultureInfo.InvariantCulture);
        Console.WriteLine(typeof(string));
        
        // Explicit Conversion
        double d = 12.345;
        Console.WriteLine($"Integer: {(int)d}");
    }
}
