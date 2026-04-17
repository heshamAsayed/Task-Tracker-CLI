
using TaskTrackerCLI.Commands.TaskProperties;
using TaskTrackerCLI.Data.Commands;

//Get  Command from CLI
var arguments = Environment.GetCommandLineArgs().Skip(1).ToArray();

if (arguments.Length == 0)
{
    Console.WriteLine("Please provide a command.");
    return;
}

// Get The Keyword of command
var command = arguments[0];
var tasks = FileHelper.Load();

switch (command)
{
    case "add":
        Add.AddTask(tasks, args);
        break;

    case "update":
        Update.UpdateTask(tasks, args);
        break;

    case "delete":
        Delete.DeleteTask(tasks, args);
        break;

    case "mark-in-progress":
        new MarkProgressTask(tasks, args);
        break;

    case "mark-done":
        new MarkDone(tasks, args);
        break;

    case "list":
        ListOf.ListOfTasks(tasks, args);
        break;

    default:
        Console.WriteLine("Unknown command");
        break;
}
FileHelper.Save(tasks);

