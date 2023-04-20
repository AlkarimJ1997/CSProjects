using System.Globalization;
using System.Text;

namespace Intro;

public static class StringBuilders
{
    public static void Run()
    {
        StringBuilder sb = new StringBuilder("Random Text");
        StringBuilder sbFixed = new StringBuilder("More stuff that is very important", 256);
        
        Console.WriteLine($"Capacity: {sbFixed.Capacity}");
        Console.WriteLine($"Length: {sbFixed.Length}");
        
        sbFixed.Append(" and more stuff");
        CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");

        string bestCustomer = "Bob Smith";
        sbFixed.AppendFormat(enUs, $"and the best customer is {bestCustomer}");
        
        Console.WriteLine($"Capacity: {sbFixed.Capacity}");
        Console.WriteLine($"Length: {sbFixed.Length}");
        Console.WriteLine(sbFixed);
        Console.WriteLine(sbFixed.ToString());
        
        sbFixed.Clear();
        sbFixed.Append("Random Text");
        
        Console.WriteLine(sbFixed);
        Console.WriteLine(sbFixed.Equals(sb));
    }
}