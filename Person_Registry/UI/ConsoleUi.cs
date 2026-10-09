namespace Person_Registry.UI;

public class ConsoleUi : IConsole
{
    public void ShowUi(string ui)
    {
        Console.WriteLine(ui);
    }

    public void ClearUi()
    {
        Console.Clear();
    }
    
    public static void WriteError(Exception e, string customMessage = "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{customMessage}...{e.Message}");
        Console.ResetColor();
    }
}