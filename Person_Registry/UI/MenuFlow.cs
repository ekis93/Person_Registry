using System.Collections.ObjectModel;
using System.Reflection;
using Person_Registry.Input;
using Person_Registry.JSON;
namespace Person_Registry.UI;

public class MenuFlow
{
    readonly ConsoleUi _ui = new();
    private Dictionary<string, string>? _collection;
    private string? _menu;
    
    public void Start()
    {
        SetMenu();
        if (_menu == null || _collection == null)
        {
            var e = new NullReferenceException(); 
            ConsoleUi.WriteError
                (e, $"Menu not set! Set the menu first!");
            throw e;
        }
        _ui.ShowUi(_menu);
        var item = PickMenuItem(_menu, _collection);
    }
    private void SetMenu()
    {
        var jsonHandler = new JsonHandler();
        var menuBuilder = new MenuBuilder();
        _collection = jsonHandler.JsonToDictionary<string>("Menu.json");
        _menu = menuBuilder.BuildMenu(_collection);
    }
    private (string key, T? value) PickMenuItem<T>
        (string menu, Dictionary<string,T> collection)
    {
        var inputHandler = new UserInputHandler();
        bool valid = false;
        string input = "";
        while (!valid)
        {
             input = inputHandler.GetUserKey();
            _ui.ResetUi(menu);
            valid = inputHandler.ValidateUserInput(collection, input);
        }
        return (input, collection.GetValueOrDefault(input));
    }
}