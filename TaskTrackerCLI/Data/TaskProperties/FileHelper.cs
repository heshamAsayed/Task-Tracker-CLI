using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TaskTrackerCLI.Commands.TaskProperties;

public class FileHelper
{
    private static string FilePath = "Task.json";

    public static List<TaskItem> Load()
    {
        if (!File.Exists(FilePath))
            return new List<TaskItem>();

        var fileJson = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<TaskItem>>(fileJson) ?? new List<TaskItem>();
    }

    public static void Save(List<TaskItem> taskItems)
    {
        var fileAsJson = JsonSerializer.Serialize(taskItems, new JsonSerializerOptions()
        {
            WriteIndented = true
        });
        
        File.WriteAllText(FilePath, fileAsJson);
    }
}