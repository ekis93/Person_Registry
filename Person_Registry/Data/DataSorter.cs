using Person_Registry.Models.Person;
namespace Person_Registry.Data;

public static class DataSorter
{
    static readonly DataStorage DataStorage = new();
    public static List<Person> SortById()
    {
        return DataStorage.GetPeople().OrderBy(p => p.IdNumber).ToList();
    }
    public static List<Person> SortFiveFirstId()
    {
        List<Person> sortedPeople = 
            DataStorage.GetPeople().OrderBy(p => p.IdNumber).ToList();
        List<Person> top5 = new List<Person>();
        for (int i = 0; i < 5; i++)
        {
            top5.Add(sortedPeople[i]);
        }
        return top5;
    }
    public static List<Person> SortByName()
    {
        return new List<Person>();
    }
    public static List<Person> SortFiveFirstName()
    {
        return new List<Person>();
    }
    public static List<Person> SortNameSearch()
    {
        return new List<Person>();
    }
}