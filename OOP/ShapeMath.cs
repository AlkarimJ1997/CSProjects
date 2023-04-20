namespace OOP;

public static class ShapeMath
{
    public static double GetArea(string shape = "", double length1 = 0, double length2 = 0)
    {
        if (string.Equals(shape, "Rectangle", StringComparison.OrdinalIgnoreCase))
        {
            return length1 * length2;
        }
        
        if (string.Equals(shape, "Triangle", StringComparison.OrdinalIgnoreCase))
        {
            return (length1 * length2) / 2;
        }
        
        if (string.Equals(shape, "Circle", StringComparison.OrdinalIgnoreCase))
        {
            return Math.PI * Math.Pow(length1, 2);
        }

        return -1;
    }
}