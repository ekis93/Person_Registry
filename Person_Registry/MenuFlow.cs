using Person_Registry.Data;
using Person_Registry.Input;
using Person_Registry.Models.Menu;
using Person_Registry.Models.Person;
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
            NullReferenceException e = new(); 
            ConsoleUi.WriteError
                (e, $"Menu not set! Set the start menu first!");
            throw e;
        }

        while (_running)
        {
            _ui.ShowUi(_menu);
            string choice = PickMenuItem(_collection);
            _ui.ClearUi();
            string menuItem = GetMenuItem(choice);
            _ui.ShowUi(menuItem,ConsoleColor.Green);
        }
        _ui.ClearUi();
        _ui.ShowUi("Exiting program.");
    }
    private void SetStartMenu()
    {
        MainMenu mainMenu = new();
        _collection = mainMenu.GetMenu();
        _menu = MenuBuilder.BuildMenu(_collection);
    }
    private string PickMenuItem(Dictionary<string,string> collection)
    {
        bool valid = false;
        string? inputKey = null;
        
        while (!valid)
        {
            inputKey = UserInputHandler.GetUserKey();
            valid = UserInputHandler.ValidateUserInput(collection, inputKey);
            if (!valid)
            {
                _ui.ClearUi();
                ConsoleUi.WriteError($"Invalid input key: {inputKey}");
                _ui.ShowUi(_menu ?? throw new NullReferenceException("_menu not set!"));
            }
        }
        
        return inputKey ?? throw new NullReferenceException("inputKey not set!");
    }
    private string GetMenuItem(string key)
    {
        string? item = null;
        
        switch (key)
        {
            // 1: Show all | ID sort | Ascending
            case "1":
                item = MenuBuilder.BuildMenu(DataSorter.GetAllById());
                break;
            // 2: Show first five | ID sort | Ascending
            case "2":
                item = MenuBuilder.BuildMenu(DataSorter.GetFiveById());
                break; 
            // 3: Show all | Name sort | Ascending
            case "3":
                item = MenuBuilder.BuildMenu(DataSorter.GetAllByName());
                break;
            // 4: Show first five | Name sort | Ascending
            case "4":
                item = MenuBuilder.BuildMenu(DataSorter.GetFiveByName());
                break;
            // 5: Search name | ID sort | Ascending
            case "5":
                _ui.ShowUi("Please provide a search term: ");
                string searchTerm = UserInputHandler.GetUserLine();
                List<Person> people = DataSorter.GetAllByNameSearch(searchTerm);
                item = MenuBuilder.BuildMenu(people);
                DataSorter.ValidateInput(item);
                break;
            // 6: Exit
            case "6": _running = false ; 
                return "";
        }
        return item ?? throw new NullReferenceException("item not set!");
    }
}