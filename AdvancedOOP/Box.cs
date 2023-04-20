namespace AdvancedOOP;

public class Box
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Breadth { get; set; }

    public Box() : this(1, 1, 1) { }

    public Box(double length, double width, double breadth)
    {
        Length = length;
        Width = width;
        Breadth = breadth;
    }

    public static Box operator +(Box box1, Box box2)
    {
        return new Box()
        {
            Length = box1.Length + box2.Length,
            Width = box1.Width + box2.Width,
            Breadth = box1.Breadth + box2.Breadth
        };
    }

    public static Box operator -(Box box1, Box box2)
    {
        return new Box()
        {
            Length = box1.Length - box2.Length,
            Width = box1.Width - box2.Width,
            Breadth = box1.Breadth - box2.Breadth
        };
    }

    public static bool operator ==(Box box1, Box box2)
    {
        const double tolerance = 0.00001;

        return Math.Abs(box1.Length - box2.Length) < tolerance &&
               Math.Abs(box1.Width - box2.Width) < tolerance &&
               Math.Abs(box1.Breadth - box2.Breadth) < tolerance;
    }

    public static bool operator !=(Box box1, Box box2) => !(box1 == box2);
    public override string ToString() => $"Box with Length: {Length}, Width: {Width}, and Breadth: {Breadth}";
    public static explicit operator int(Box box) => (int)(box.Length * box.Width * box.Breadth) / 3;
    public static implicit operator Box(int i) => new Box(i, i, i);
}