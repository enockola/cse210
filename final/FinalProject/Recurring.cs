public class Recurring : Task
{
    protected string _recurrence;

    public Recurring() : base() { }

    public Recurring(string taskDescription, string taskPriority, string taskDate, string recurrence)
        : base(taskDescription, taskPriority, taskDate)
    {
        _recurrence = recurrence;
    }

    public override void InputDetails()
    {
        Console.WriteLine("Recurring Task:");
        Console.WriteLine("A project-related task that can repeat at regular intervals (such as daily, weekly, monthly, yearly).");
        Console.WriteLine("E.G. 'Go to Work'.");
        Console.Write("Enter task description: ");
        _taskDescription = Console.ReadLine();
        Console.Write("Enter task priority (Low, Medium, High): ");
        _taskPriority = Console.ReadLine();
        Console.Write("Enter activity time: ");
        _taskDate = Console.ReadLine();
        Console.Write("Enter recurrence (Daily, Weekly, Monthly, Yearly): ");
        _recurrence = Console.ReadLine();
    }

    public override string GetExtraInfo()
    {
        return _recurrence;
    }

    public override string ToString()
    {
        return base.ToString() + $", Recurrence: {_recurrence}";
    }
}