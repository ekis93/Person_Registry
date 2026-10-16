using Person_Registry.Data;
using Person_Registry.Models.Menu;

namespace Person_Registry;

public static class MenuFlow
{
    private static string? _menu;
    private static bool _running = true;
    
    public static void Start()
    {
        SetStartMenu();
        if (_menu == null) throw new NullReferenceException("Menu not set!");
        _menu.ShowUi();
        while (_running) _menu.PutUnder(GetMenuItem()).ClearUi().ShowUi();
    }
    private static void SetStartMenu()
    {
        MainMenu mainMenu = new();
        _menu = mainMenu.GetMenu().BuildMenu();
    }
    private static string GetMenuItem()
    {
        string key = UserInputHandler.GetUserKey();
        switch (key)
        {
            case "1":
                return DataSorter.GetAllById().BuildMenu();
            case "2":
                return DataSorter.GetFiveById().BuildMenu();
            case "3":
                return DataSorter.GetAllByName().BuildMenu();
            case "4":
                return DataSorter.GetFiveByName().BuildMenu();
            case "5":
                Ui.Show("Please provide a search term:");
                string term = UserInputHandler.GetUserLine();
                return DataSorter.GetAllByNameSearch(term).BuildMenu().Validate();
            case "6":
                _running = false;
                return "";
        }
        return $"Invalid menu choice: {key}!";
    }
}