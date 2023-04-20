namespace OOPContinued;

internal class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Name = "Circle";
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"It has a Radius of {Radius}");
    }
}