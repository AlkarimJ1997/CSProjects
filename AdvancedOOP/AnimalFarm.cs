using System.Collections;

namespace AdvancedOOP;

public class AnimalFarm : IEnumerable
{
    private List<Animal> _animalList = new List<Animal>();

    public AnimalFarm(List<Animal> animalList)
    {
        _animalList = animalList;
    }

    public AnimalFarm() { }

    public Animal this[int index]
    {
        get => _animalList[index];
        set => _animalList.Insert(index, value);
    }

    public int Count => _animalList.Count;

    public IEnumerator GetEnumerator()
    {
        return _animalList.GetEnumerator();
    }
}