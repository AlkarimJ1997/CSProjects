namespace Intro;

public static class Arrays
{
    public static void Run()
    {
        int[] nums = new int[3];
        string[] customerNames = { "John", "Mary", "Bob" };
        var employees = new[] { "John", "Mary", "Bob" };
        
        // Dynamic Array
        object[] dynamicArray = { "John", 1, 2.5, true };

        nums[0] = 1;
        nums[1] = 2;
        nums[2] = 3;

        Console.WriteLine(nums[0]);
        Console.WriteLine(customerNames[1]);
        Console.WriteLine(employees[2]);
        Console.WriteLine(dynamicArray[3]);
        Console.WriteLine($"Size: {nums.Length}");
    }
}