namespace OOPComplex;

internal class Television : IElectronicDevice
{
    public int Volume { get; set; }

    public void On()
    {
        Console.WriteLine("TV is on");
    }

    public void Off()
    {
        Console.WriteLine("TV is off");
    }

    public void VolumeUp()
    {
        if (Volume < 100) Volume++;
        Console.WriteLine("TV Volume is at: " + Volume);
    }

    public void VolumeDown()
    {
        if (Volume > 0) Volume--;
        Console.WriteLine("TV Volume is at: " + Volume);
    }
}