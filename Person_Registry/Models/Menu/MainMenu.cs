namespace Person_Registry.Models.Menu;

public class MainMenu : IMenu
{
    public Dictionary<string,string> GetMenu()
    {
        return new Dictionary<string, string>()
        {
            {"1","Show all | ID sort | Ascending"},
            {"2", "Show first five | ID sort | Ascending"},
            {"3", "Show all | Name sort | Ascending"},
            {"4", "Show first five | Name sort | Ascending"},
            {"5", "Search name | ID sort | Ascending"},
            {"6", "Exit"}
        };
    }
}