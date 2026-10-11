namespace Person_Registry.UI;

public class ConsoleUi : IConsole
{
    public void ShowUi(string uiText)
    {
        Console.WriteLine(uiText);
    }
    public void ShowUi(string uiText, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(uiText);
        Console.ResetColor();
    }
    public void ClearUi()
    {
        Console.Clear();
    }
    public void ResetUi(string uiText)
    {
        ClearUi();
        ShowUi(uiText);
    }
    public static void WriteError(Exception e, string customMessage = "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{customMessage}...{e.Message}");
        Console.ResetColor();
    }
}