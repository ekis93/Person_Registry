using Person_Registry.Models.Person;
using Person_Registry.UI;

namespace Person_Registry.Data;

public static class DataSorter
{
    static readonly DataStorage DataStorage = new();
    public static List<Person> GetAllById()
    {
        return DataStorage.GetPeople().OrderById();
    }
    public static List<Person> GetFiveById()
    {
        return DataStorage.GetPeople().OrderById().GetFirstFive();
    }
    public static List<Person> GetAllByName()
    {
        return DataStorage.GetPeople().OrderByName();
    }
    public static List<Person> GetFiveByName()
    {
        return DataStorage.GetPeople().OrderByName().GetFirstFive();
    }
    public static List<Person> GetAllByNameSearch(string searchTerm)
    {
        return DataStorage.GetPeople().FindAllNames(searchTerm).OrderById();
    }
    public static void ValidateInput(string text)
    {
        if (string.IsNullOrEmpty(text)) ConsoleUi.WriteError("No match found!");
    }
}

public static class ListExtensions
{
    public static List<Person> OrderById(this List<Person> people)
    {
        return people.OrderBy(p => p.IdNumber).ToList();
    }
    public static List<Person> OrderByName(this List<Person> people)
    {
        return people.OrderBy(p => p.Name).ToList();
    }
    public static List<Person> FindAllNames(this List<Person> people, string searchTerm)
        {
            return people.FindAll(p => p.Name.Contains(searchTerm));
        }
    public static List<Person> GetFirstFive(this List<Person> people)
        {
            using var enumerator = people.GetEnumerator();
            List<Person> firstFive = new();
            for (int i = 0; i < 5; i++)
            {
                enumerator.MoveNext();
                firstFive.Add(enumerator.Current);
            }
            return firstFive;
        }
}
