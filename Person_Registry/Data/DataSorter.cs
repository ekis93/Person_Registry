using Person_Registry.Models;

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
}
