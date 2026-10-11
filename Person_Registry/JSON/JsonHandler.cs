using System.Text.Json;
using Person_Registry.UI;

// ReSharper disable InconsistentNaming
namespace Person_Registry.JSON;

public class JsonHandler
{
    private string _json { get; set; } = string.Empty;
    public Dictionary<string,T> JsonToDictionary<T>(string filename)
    {
        try
        {
            string filePath = GetJsonPath(filename);
            _json = File.ReadAllText(filePath);
        }
        catch (FileNotFoundException e)
        {
            ConsoleUi.WriteError(e, "File not found");
            throw;
        }
        catch (ArgumentException e)
        {
            ConsoleUi.WriteError(e, "Empty path");
            throw;
        }

        Dictionary<string,T> collection;

        try
        {
            collection = JsonSerializer.Deserialize<Dictionary<string, T>>(_json) ?? [];
        }
        catch (JsonException e)
        {
            ConsoleUi.WriteError(e, "Invalid JSON format");
            throw;
        }
        return collection;
    }
    
    /// <summary>
    /// Returns the path to the given file relative to the current project directory.
    /// </summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    private string GetJsonPath(string filename)
    {
        string workingDirectory = Directory.GetCurrentDirectory();
        string? projectDirectory = Directory.GetParent(workingDirectory)?.Parent?.Parent?.FullName;
        return Path.Join(projectDirectory, "JSON/", filename);
    }
}