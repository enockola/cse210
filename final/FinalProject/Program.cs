class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        CompletedTask completedTask = new CompletedTask();
        FileManager fileManager = new FileManager();

        List<Task> tasks = fileManager.LoadTasks();
        if (tasks != null)
        {
            taskManager.SetTasks(tasks);
        }

        Console.Clear();
        Console.WriteLine("Welcome to Task Manager!");
        Console.WriteLine("Manage your tasks well before it's due.\n");
        WaitForUserInput();
        Thread.Sleep(1000);
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine($"You have {taskManager.GetTaskCount()} tasks incomplete.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("   1. Add a new task");
            Console.WriteLine("   2. Remove a task");
            Console.WriteLine("   3. Update a task");
            Console.WriteLine("   4. Complete a task");
            Console.WriteLine("   5. View all tasks");
            Console.WriteLine("   6. View completed tasks");
            Console.WriteLine("   7. Save and Exit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    taskManager.AddNewTask();
                    break;
                case "2":
                    taskManager.RemoveTask();
                    break;
                case "3":
                    taskManager.UpdateTask();
                    break;
                case "4":
                    taskManager.CompleteTask(completedTask);
                    break;
                case "5":
                    taskManager.PrintAllTasks();
                    WaitForUserInput();
                    break;
                case "6":
                    completedTask.PrintAllCompletedTasks();
                    WaitForUserInput();
                    break;
                case "7":
                    fileManager.SaveTasks(taskManager.GetAllTasks(), completedTask.GetAllCompletedTasks());
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void WaitForUserInput()
    {
        Console.Write("\nPress any key to continue...");
        Console.ReadKey();
    }
}