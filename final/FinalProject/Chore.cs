public class Chore : Task
{
    private string _timeToComplete;

    public Chore() : base() { }

    public Chore(string taskDescription, string taskPriority, string taskDate, string timeToComplete)
        : base(taskDescription, taskPriority, taskDate)
    {
        _timeToComplete = timeToComplete;
    }

    public override void InputDetails()
    {
        Console.WriteLine("Chore:");
        Console.WriteLine("A duty or task that you're obligated to perform, often one that is unpleasant but necessary.");
        Console.WriteLine("E.G. 'washing the dishes' , 'completing an assignment.'");
        Console.Write("Enter chore description: ");
        _taskDescription = Console.ReadLine();
        Console.Write("Enter task priority (Low, Medium, High): ");
        _taskPriority = Console.ReadLine();
        Console.Write("Enter chore date: ");
        _taskDate = Console.ReadLine();
        Console.Write("Enter time needed to complete this chore: ");
        _timeToComplete = Console.ReadLine();
    }

    public override string GetExtraInfo()
    {
        return $"Time to Complete: {_timeToComplete}";
    }
}