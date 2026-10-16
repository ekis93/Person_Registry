namespace Person_Registry;

public static class UserInputHandler
{
    public static string GetUserKey()
    {
        //TODO: Implement a check in case the user pastes a string of text to the console.
        return Console.ReadKey(true).KeyChar.ToString();
    }
    public static string GetUserLine()
    {
        return Console.ReadLine() ?? "";
    }
}