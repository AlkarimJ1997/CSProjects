namespace OOP;

public class Animal
{
    private string _name;
    private string _sound;
    protected AnimalIdInfo AnimalIdInfo = new AnimalIdInfo();

    public void SetAnimalIdInfo(int idNum, string owner)
    {
        AnimalIdInfo.IdNum = idNum;
        AnimalIdInfo.Owner = owner;
    }

    public void GetAnimalIdInfo()
    {
        Console.WriteLine($"{_name} has the ID of {AnimalIdInfo.IdNum} and is owned by {AnimalIdInfo.Owner}");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{_name} says {_sound}");
    }

    public Animal(string name = "No Name", string sound = "No Sound")
    {
        _name = name;
        _sound = sound;
    }

    public string Name
    {
        get => _name;
        set => _name = (value.Any(char.IsDigit)) ? "No Name" : value;
    }

    public string Sound
    {
        get => _sound;
        set => _sound = (value.Length > 10) ? "No Sound" : value;
    }

    public class AnimalHealth
    {
        public bool HealthyWeight(double height, double weight)
        {
            double calc = height / weight;
            return calc is >= 0.18 and <= 0.27;
        }
    }
}