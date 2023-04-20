namespace Intro;

public static class Loops
{
    private static void PrintArray(int[] intArray, string message)
    {
        foreach (int n in intArray)
        {
            Console.WriteLine($"{message}: {n}");
        }
    }

    public static void Run()
    {
        int[] nums = new int[3];
        string[] customerNames = { "John", "Mary", "Bob" };
        var employees = new[] { "John", "Mary", "Bob" };
        object[] dynamicArray = { "John", 1, 2.5, true };

        nums[0] = 7;
        nums[1] = 15;
        nums[2] = 1;

        // For Loop
        for (int i = 0; i < dynamicArray.Length; i++)
        {
            Console.WriteLine(dynamicArray[i]);
        }

        Console.WriteLine("-----------------------");

        // 2D Arrays
        string[,] names = new string[2, 3] { { "John", "Mary", "Bob" }, { "Mike", "Julia", "Justin" } };
        Console.WriteLine(names.GetValue(1, 2));

        Console.WriteLine("-----------------------");

        PrintArray(nums, "ForEach");

        // Sorting
        Array.Sort(nums);
        PrintArray(nums, "Sorted");

        // Reverse
        Array.Reverse(nums);
        PrintArray(nums, "Reversed");

        // Searching
        Console.WriteLine(Array.IndexOf(nums, 15));
        Console.WriteLine("-----------------------");
        
        // Filtering
        var filtered = Array.FindAll(nums, n => n > 5);
        PrintArray(filtered, "Filtered");
    }
}