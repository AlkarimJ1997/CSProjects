namespace Intro;

public static class Conditionals
{
    public static void Run()
    {
        // Relational Operators
        // >, <, >=, <=, ==, !=
        
        // Logical Operators
        // &&, ||, !
        
        // Conditional Operators
        // ?:, ??, ??=

        const int age = 17;

        if (age >= 5 && age <= 7)
        {
            Console.WriteLine("Go to Elementary School");
        } else if (age >= 8 && age <= 13)
        {
            Console.WriteLine("Go to Middle School");
        } else if (age >= 14 && age <= 18)
        {
            Console.WriteLine("Go to High School");
        } else
        {
            Console.WriteLine("Go to College");
        }
    }
}