namespace Intro;

public static class DateTimes
{
    // ----- FUNCTIONS -----
    
    // ----- END OF FUNCTIONS -----
    public static void Run()
    {
        DateTime dt = new DateTime(1974, 12, 21);
        
        Console.WriteLine(dt);
        Console.WriteLine(dt.DayOfWeek);
        
        dt = dt.AddDays(4);
        dt = dt.AddMonths(1);
        dt = dt.AddYears(1);
        
        Console.WriteLine(dt);
        Console.WriteLine("------------");

        TimeSpan lunchTime = new TimeSpan(12, 30, 0);
        
        Console.WriteLine(lunchTime);
        
        lunchTime = lunchTime.Subtract(TimeSpan.FromMinutes(15));
        
        Console.WriteLine(lunchTime);
    }
}