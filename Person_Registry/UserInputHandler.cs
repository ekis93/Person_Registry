namespace Person_Registry;

public static class UserInputHandler
{
    public static string GetUserKey()
    {
        return Console.ReadKey(true).KeyChar.ToString();
    }
    public static string GetUserLine()
    {
        return Console.ReadLine() ?? "";
    }
}