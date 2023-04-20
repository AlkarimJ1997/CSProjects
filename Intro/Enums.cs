namespace Intro;

public static class Enums
{
    // ----- FUNCTIONS -----

    private static void PaintCar(CarColor cc)
    {
        Console.WriteLine($"The car was painted {cc} with the code {(int)cc}");
    }
    
    // ----- END OF FUNCTIONS -----
    private enum CarColor : byte { Orange = 1, Blue, Green, Red, Yellow }
    public static void Run()
    {
        const CarColor myCar = CarColor.Blue;
        
        PaintCar(myCar);
    }
}