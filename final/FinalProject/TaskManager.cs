public class TaskManager
{
    private List<Task> _tasks = new List<Task>();

    public void SetTasks(List<Task> tasks)
    {
        _tasks = tasks;
    }

    public List<Task> GetAllTasks()
    {
        return _tasks;
    }
    
    public void AddNewTask()
    {
        Console.Clear();
        Console.WriteLine("Adding a task...");
        Thread.Sleep(1000);
        Console.WriteLine("What type of task do you want to add: \n1. Chore \n2. Schedule \n3. Recurring \n4. Reminder");
        Console.Write("[");
        string typeChoice = Console.ReadLine();
        Console.SetCursorPosition(2, Console.CursorTop -1);
        Console.Write("] ");

        Task newTask;
        switch (typeChoice)
        {
            case "1":
                newTask = new Chore();
                break;
            case "2":
                newTask = new Schedule();
                break;
            case "3":
                newTask = new Recurring();
                break;
            case "4":
                newTask = new Reminder();
                break;
            default:
                Console.WriteLine("Invalid task type. Task not added.");
                return;
        }

        newTask.InputDetails();
        _tasks.Add(newTask);
        Console.WriteLine("\nTask added successfully.");
    }

    public void RemoveTask()
    {
        Console.Clear();
        Console.WriteLine("Removing a task...");
        Thread.Sleep(1000);
        PrintTask();
        Console.Write("Enter the task number to remove: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            if (taskNumber > 0 && taskNumber <= _tasks.Count)
            {
                _tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    public void UpdateTask()
    {
        Console.Clear();
        Console.WriteLine("Updating a task...");
        Thread.Sleep(1000);
        PrintTask();
        Console.Write("Enter the task number to update: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            if (taskNumber > 0 && taskNumber <= _tasks.Count)
            {
                Console.Write("Enter the new description: ");
                string newDescription = Console.ReadLine();
                Console.Write("Enter the new priority (Low, Medium, High): ");
                string newPriority = Console.ReadLine();
                _tasks[taskNumber - 1].UpdateDetails(newDescription, newPriority);
                Console.WriteLine("Task updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    public void CompleteTask(CompletedTask completedTask)
    {
        Console.Clear();
        Console.WriteLine("Completing a task...");
        Thread.Sleep(1000);
        PrintTask();
        Console.Write("Enter the task number to complete: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            if (taskNumber > 0 && taskNumber <= _tasks.Count)
            {
                completedTask.AddCompletedTask(_tasks[taskNumber - 1]);
                _tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task completed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    public void PrintTask()
    {
        Console.WriteLine("\nTasks:");
        for (int i = 0; i < _tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_tasks[i]}");
        }
    }

    public void PrintAllTasks()
    {
        Console.Clear();
        Console.WriteLine("\nIncomplete Tasks:");
        for (int i = 0; i < _tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_tasks[i]}");
        }
    }

    public int GetTaskCount()
    {
        return _tasks.Count;
    }
}
