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
            var choice = PickMenuItem(_menu, _collection);
            ShowMenuItem(choice.key);
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
    private (string key, string? value) PickMenuItem
        (string menu, Dictionary<string,string> collection)
    {
        var inputHandler = new UserInputHandler();
        bool valid = false;
        string input = "";
        while (!valid)
        {
            input = inputHandler.GetUserKey();
            valid = inputHandler.ValidateUserInput(collection, input);
        }
        return (input, collection.GetValueOrDefault(input));
    }
    private void ShowMenuItem(string key)
    {
        _ui.ClearUi();
        string item = "";
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
                return;
        }
        _ui.ShowUi(item,ConsoleColor.Green);
    }
}