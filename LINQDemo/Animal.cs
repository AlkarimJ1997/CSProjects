namespace LINQDemo;

public class Animal
{
    public string Name { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public int AnimalId { get; set; }
    
    public Animal(string name = "No Name", double height = 0, double weight = 0)
    {
        Name = name;
        Height = height;
        Weight = weight;
    }
    
    public override string ToString() => $"{Name} is {Height} inches tall and weighs {Weight} pounds";
}