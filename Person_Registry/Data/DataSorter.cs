using Person_Registry.Models;

namespace Person_Registry.Data;

/// <summary>
/// Contains methods used to sort through list data and return a list with a given sorting order.
/// </summary>
public static class DataSorter
{
    static readonly DataStorage DataStorage = new();
    /// <summary>
    /// Returns an ordered List of type person containing the
    /// entire collection of Person items sorted by the ID property.
    /// </summary>
    /// <returns><see cref="Person"/></returns>
    public static List<Person> GetAllById()
    {
        return DataStorage.GetPeople().OrderById();
    }
    /// <summary>
    /// Returns an ordered List of type Person
    /// containing five Person items sorted by the ID property. 
    /// </summary>
    /// <returns><see cref="Person"/></returns>
    public static List<Person> GetFiveById()
    {
        return DataStorage.GetPeople().OrderById().GetFirstFive();
    }
    /// <summary>
    /// Returns an ordered List of type person containing the
    /// entire collection of Person items sorted by the Name property.
    /// </summary>
    /// <returns><see cref="Person"/></returns>
    public static List<Person> GetAllByName()
    {
        return DataStorage.GetPeople().OrderByName();
    }
    /// <summary>
    /// Returns an ordered List of type Person
    /// containing five Person items sorted by the Name property. 
    /// </summary>
    /// <returns><see cref="Person"/></returns>
    public static List<Person> GetFiveByName()
    {
        return DataStorage.GetPeople().OrderByName().GetFirstFive();
    }
    /// <summary>
    /// Returns an ordered List of type person containing all the Person items
    /// whose Name property matches the given search term parameter.
    /// </summary>
    /// <returns><see cref="Person"/></returns>
    public static List<Person> GetAllByNameSearch(string searchTerm)
    {
        return DataStorage.GetPeople().FindAllNames(searchTerm).OrderById();
    }
}
