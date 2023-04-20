namespace Intro;

public static class UserInput
{
    public static void Run()
    {
        Console.WriteLine("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello {name}");
    }
}
