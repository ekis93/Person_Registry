using Person_Registry.Models.Person;
namespace Person_Registry;

public static class MenuBuilder
{
    public static string BuildMenu(Dictionary<string,string> collection)
    {
        string menu = "";
        foreach (var item in collection)
        {
            menu += $"\n{item.Key}: {item.Value}";
        }
        return menu;
    }
    public static string BuildMenu(List<Person> people)
    {
        string menu = "";
        foreach (var person in people)
        {
            menu += "\n\n";
            foreach (var property in person.GetPersonProperties())
            {
                menu += property +"\n";
            }
        }
        return menu;
    }
}