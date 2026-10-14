namespace Person_Registry.Input;

public class UserInputHandler
{
    /// <summary>
    /// Validates the user's input to the console.
    /// </summary>
    /// <returns>True if any key matches the input, false if not.</returns>
    public bool ValidateUserInput(Dictionary<string,string> collection, string input)
    {
        return collection.ContainsKey(input);
    }
    public string GetUserKey()
    {
        //TODO: Implement a check in case the user pastes a string of text to the console.
        return Console.ReadKey().KeyChar.ToString();
    }
    public string GetUserLine()
    {
        return Console.ReadLine() ?? "";
    }
}