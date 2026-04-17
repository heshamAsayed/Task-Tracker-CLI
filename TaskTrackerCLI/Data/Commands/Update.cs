using TaskTrackerCLI.Commands.TaskProperties;

namespace TaskTrackerCLI.Data.Commands;

public static class Update
{

    public static void UpdateTask(List<TaskItem> tasks, string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Missing description");
            return;
        }
        if (!int.TryParse(args[1], out int id))
        {
            Console.WriteLine("Invalid ID");
            return;
        }
        
        var task = tasks.FirstOrDefault(t => t.Id == id);
        
        if (task == null)
        {
            Console.WriteLine("Task not found");
            return;
        }
        
        task.Description = args[2];
        task.LastModified = DateTime.Now;

        Console.WriteLine("Task updated successfully");
    }
}