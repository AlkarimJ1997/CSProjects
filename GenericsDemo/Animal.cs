namespace GenericsDemo;

public class Animal
{
    public string Name { get; set; }
    
    public Animal(string name = "No Name")
    {
        Name = name;
    }

    public static void GetSum<T>(ref T num1, ref T num2)
    {
        double d1 = Convert.ToDouble(num1);
        double d2 = Convert.ToDouble(num2);
        
        Console.WriteLine($"{d1} + {d2} = {d1 + d2}");
    }
}