namespace Intro;

public static class FormattingOutput
{
    public static void Run()
    {
        Console.WriteLine("Currency: {0:C}", 123.45);
        Console.WriteLine("Pad with 0s: {0:D4}", 123);
        Console.WriteLine("Three decimals: {0:F3}", 123.4567);
        Console.WriteLine("Comma separator: {0:N4}", 2300);
    }
}
