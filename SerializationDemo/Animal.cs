using System.Runtime.Serialization;

namespace SerializationDemo;

[Serializable]
public class Animal : ISerializable
{
    public string Name { get; set; } = "No Name";
    public double Weight { get; set; }
    public double Height { get; set; }
    public int AnimalId { get; set; }

    public Animal() { }

    public Animal(string name = "No Name", double weight = 0, double height = 0, int animalId = 0)
    {
        Name = name;
        Weight = weight;
        Height = height;
        AnimalId = animalId;
    }

    public override string ToString() => $"{Name} weighs {Weight} lbs and is {Height} inches tall";

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Name", Name);
        info.AddValue("Weight", Weight);
        info.AddValue("Height", Height);
        info.AddValue("AnimalId", AnimalId);
    }

    public Animal(SerializationInfo info, StreamingContext context)
    {
        Name = info.GetString("Name") ?? "No Name";
        Weight = info.GetDouble("Weight");
        Height = info.GetDouble("Height");
        AnimalId = info.GetInt32("AnimalId");
    }
}