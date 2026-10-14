using Person_Registry.Data;
using Person_Registry.Input;
using Person_Registry.Models.Menu;
using Person_Registry.UI;

namespace Person_Registry;

public class MenuFlow
{
    readonly ConsoleUi _ui = new();
    private Dictionary<string, string>? _collection;
    private string? _menu;
    private bool _running = true;
    
    public void Start()
    {
        SetStartMenu();
        if (_menu == null || _collection == null)
        {
            var e = new NullReferenceException(); 
            ConsoleUi.WriteError
                (e, $"Menu not set! Set the start menu first!");
            throw e;
        }
        _ui.ShowUi(_menu);
        while (_running)
        {
            string choice = PickMenuItem(_collection);
            string menuItem = GetMenuItem(choice);
            _ui.ClearUi();
            _ui.ShowUi(menuItem,ConsoleColor.Green);
            _ui.ShowUi(_menu);
            
        }
        _ui.ClearUi();
    }
    private void SetStartMenu()
    {
        MainMenu mainMenu = new();
        _collection = mainMenu.GetMenu();
        _menu = MenuBuilder.BuildMenu(_collection);
    }
    private string PickMenuItem(Dictionary<string,string> collection)
    {
        var inputHandler = new UserInputHandler();
        bool valid = false;
        string? inputKey = null;
        
        while (!valid)
        {
            inputKey = inputHandler.GetUserKey();
            valid = inputHandler.ValidateUserInput(collection, inputKey);
            if (!valid)
            {
                _ui.ResetUi(_menu ?? throw new NullReferenceException("_menu not set!"));
                ConsoleUi.WriteError($"Invalid input key: {inputKey}");
            }
        }
        
        if (inputKey != null) return inputKey;
        throw new NullReferenceException("inputKey not set!");
    }
    private string GetMenuItem(string key)
    {
        string? item = null;
        
        switch (key)
        {
            // 1: Show all | ID sort | Ascending
            case "1":
                item = MenuBuilder.BuildMenu(DataSorter.SortById());
                break;
            // 2: Show first five | ID sort | Ascending
            case "2":
                item = MenuBuilder.BuildMenu(DataSorter.SortFiveFirstId());
                break; 
            // 3: Show all | Name sort | Ascending
            case "3":
                item = MenuBuilder.BuildMenu(DataSorter.SortByName());
                break;
            // 4: Show first five | Name sort | Ascending
            case "4":
                item = MenuBuilder.BuildMenu(DataSorter.SortFiveFirstName());
                break;
            // 5: Search name | ID sort | Ascending
            case "5":
                item = MenuBuilder.BuildMenu(DataSorter.SortNameSearch());
                break;
            // 6: Exit
            case "6": _running = false ; 
                return "";
        }
        
        if (item != null) return item;
        throw new NullReferenceException("item not set!");
    }
}