namespace Person_Registry.UI;

public class MenuBuilder
{
    public string BuildMenu<T>(Dictionary<string,T> collection)
    {
        string menu = "";
        foreach (var item in collection)
        {
            menu += $"\n\n{item.Key}: {item.Value}";
        }
        return menu;
    }
}