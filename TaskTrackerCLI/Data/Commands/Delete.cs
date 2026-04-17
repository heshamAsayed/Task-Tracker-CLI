using TaskTrackerCLI.Commands.TaskProperties;

namespace TaskTrackerCLI.Data.Commands;

public static class Delete
{
    public static void DeleteTask(List<TaskItem> tasks, string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Missing ID");
            return;
        }
        
        int id = int.Parse(args[0]);
        var task  = tasks.FirstOrDefault(t => t.Id == id);
        if (task == null) 
        {
            Console.WriteLine("Task not found");
            return;
        }
        
        tasks.Remove(task);
        Console.WriteLine("Task deleted");
    }
}