using TaskTrackerCLI.Commands.TaskProperties;

namespace TaskTrackerCLI.Data.Commands;

public static class ListOf
{
    public static void ListOfTasks(List<TaskItem> tasks, string[] args)
    {
        var filter = args.Length > 1 ? args[1] : "all";

        var filtered = filter switch
        {
            "done" => tasks.Where(t => t.Status == "done"),
            "todo" => tasks.Where(t => t.Status == "todo"),
            "in-progress" => tasks.Where(t => t.Status == "in-progress"),
            _ => tasks
        };
        
        foreach (var t in filtered)
        {
            Console.WriteLine($"{t.Id} | {t.Description} | {t.Status}");
        }
    }
}