public class Schedule : Task
{
    public Schedule() : base() { }

    public Schedule(string taskDescription, string taskPriority, string taskDate)
        : base(taskDescription, taskPriority, taskDate) { }

    public override void InputDetails()
    {
        Console.WriteLine("Schedule:");
        Console.WriteLine("An arranged plan for events to take place, giving lists of intended events and times.");
        Console.WriteLine("E.G. 'Interview meeting' , 'Doctor's Appointment.'");
        Console.Write("Enter schedule description: ");
        _taskDescription = Console.ReadLine();
        Console.Write("Enter task priority (Low, Medium, High): ");
        _taskPriority = Console.ReadLine();
        Console.Write("Enter the scheduled date: ");
        _taskDate = Console.ReadLine();
    }

    public override string GetExtraInfo()
    {
        return string.Empty;
    }
}
