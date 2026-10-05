namespace Person_Registry.UI;

public class ConsoleUi : IConsole
{
    public void ShowUi(string menu)
    {
        Console.WriteLine(menu);
    }

    public void ClearUi()
    {
        Console.Clear();
    }
}