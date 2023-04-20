namespace Intro;

public static class Exceptions
{
    public static void Run()
    {
        int num = 5;
        int denominator = 0;

        try
        {
            Console.WriteLine($"5 / 0 = {num / denominator}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("This will always run");
        }
    }
}