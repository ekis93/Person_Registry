using Person_Registry.Data;
using Person_Registry.Models.Menu;

namespace Person_Registry;

public static class MenuFlow
{
    private static string? _mainMenu;
    private static bool _running = true;
    
    public static void Start()
    {
        SetStartMenu();
        if (_mainMenu == null) throw new NullReferenceException("Menu not set!");
        _mainMenu.ShowUi();
        while (_running) _mainMenu.PutUnder(GetMenuItem()).ClearUi().ShowUi();
        _mainMenu.ClearUi();
        Ui.ShowUi("Exiting Program.");
    }
    private static void SetStartMenu()
    {
        MainMenu mainMenu = new();
        _mainMenu = mainMenu.GetMenu().BuildMenu();
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
                _mainMenu?.ClearUi();
                Ui.ShowUi("Please provide a search term:");
                string term = UserInputHandler.GetUserLine();
                return DataSorter.GetAllByNameSearch(term).BuildMenu().Validate().PutUnder($"Search: {term}");
            case "6":
                _running = false;
                return "";
        }
        return $"Invalid menu choice: {key}!";
    }
}