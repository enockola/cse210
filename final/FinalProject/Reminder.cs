public class Reminder : Task
{
    public Reminder() : base() { }

    public Reminder(string taskDescription, string taskPriority, string taskDate)
        : base(taskDescription, taskPriority, taskDate) { }

    public override void InputDetails()
    {
        Console.WriteLine("Reminder:");
        Console.WriteLine("A virtual list that helps you keep track of tasks and deadlines.");
        Console.WriteLine("E.G. 'Take medication'.");
        Console.Write("Enter reminder description: ");
        _taskDescription = Console.ReadLine();
        Console.Write("Enter task priority (Low, Medium, High): ");
        _taskPriority = Console.ReadLine();
        Console.Write("Enter reminder date: ");
        _taskDate = Console.ReadLine();
    }

    public override string GetExtraInfo()
    {
        return string.Empty;
    }
}