using Person_Registry.Models;

namespace Person_Registry;

public static class StringExtensions
{
    public static void Show(this string str)
    {
        Console.WriteLine(str);
    }
    public static string ClearUi(this string str)
    {
        Console.Clear();
        return str;
    }
    public static string PutUnder(this string str, string text)
    {
        return $"{text}\n{str}";
    }
    public static string Validate(this string str)
    {
        return String.IsNullOrEmpty(str) ? "No match found!" : str;
    }
}

public static class DictionaryExtensions
{
    public static string BuildMenu(this Dictionary<string, string> collection)
    {
        string menu = "";
        foreach (var item in collection)
        {
            menu += $"\n{item.Key}: {item.Value}";
        }

        return menu;
    }
}

public static class ListExtensions
{
    public static string BuildMenu(this List<Person> people)
    {
        string menu = "";
        foreach (var person in people)
        {
            menu += "\n\n";
            foreach (var property in person.GetPersonProperties())
            {
                menu += property + "\n";
            }
        }
        return menu;
    }
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
        return string.IsNullOrWhiteSpace(searchTerm) 
            ? new List<Person>() : people.Where(p => p.Name.Contains(searchTerm)).ToList();
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