public class TaskOption
{
    private Tasklist _taskList;
    private CompletedTaskList _completedTaskList;

    public TaskOption(Tasklist taskList, CompletedTaskList completedTaskList)
    {
        _taskList = taskList;
        _completedTaskList = completedTaskList;
    }

    public void AddNewTask()
    {
        Console.Clear();
        Console.WriteLine("Adding a task...");
        Thread.Sleep(1000);
        Console.WriteLine("What type of task do you want to add: \n1. Chore \n2. Schedule \n3. Recurring \n4. Reminder");
        string typeChoice = Console.ReadLine();
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();
        Console.Write("Enter task priority (Low, Medium, High): ");
        string priority = Console.ReadLine();
        Console.Write("Enter task date: ");
        string date = Console.ReadLine();

        Task newTask;
        switch (typeChoice)
        {
            case "1":
                newTask = new Chore(description, priority, date);
                break;
            case "2":
                newTask = new Schedule(description, priority, date);
                break;
            case "3":
                newTask = new Recurring(description, priority, date);
                break;
            case "4":
                newTask = new Reminder(description, priority, date);
                break;
            default:
                Console.WriteLine("Invalid task type. Task not added.");
                return;
        }

        _taskList.AddTask(newTask);
        Console.WriteLine("Task added successfully.");
    }

    public void RemoveTask()
    {
        Console.Write("Enter the task number to remove: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            _taskList.RemoveTask(taskNumber - 1);
            Console.WriteLine("Task removed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    public void UpdateTask()
    {
        Console.Write("Enter the task number to update: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            Console.Write("Enter the new description: ");
            string newDescription = Console.ReadLine();
            Console.Write("Enter the new priority (Low, Medium, High): ");
            string newPriority = Console.ReadLine();
            _taskList.UpdateTask(taskNumber - 1, newDescription, newPriority);
            Console.WriteLine("Task updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    public void CompleteTask()
    {
        Console.Write("Enter the task number to complete: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            _taskList.CompleteTask(taskNumber - 1, _completedTaskList);
            Console.WriteLine("Task completed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}