using Person_Registry.JSON;
namespace Person_Registry.UI;

public class Menu
{
    public void Start()
    {
        ConsoleUi ui = new ConsoleUi();
        string menu = GetMenuFromJson("Menu.json");
        ui.ShowUi(menu);
    }
    private string GetMenuFromJson(string filename)
    {
        JsonHandler handler = new JsonHandler();
        var collection = handler.JsonToDictionary<string>(filename);
        
        string menu = string.Empty;
        foreach (var item in collection)
        {
            menu += $"\n{item.Key}: {item.Value}";
        }
        return menu;
    }
}