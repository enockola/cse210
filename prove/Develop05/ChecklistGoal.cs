public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _isCompleted = true;
            Console.WriteLine($"Completed: {_goalName} (+{_points + _bonusPoints} points)");
        }
        else
        {
            Console.WriteLine($"Recorded: {_goalName} (+{_points} points)");
        }
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(_isCompleted ? $"[X] {_goalName} (+{_points + _bonusPoints} points)" : $"[ ] {_goalName} ({_currentCount}/{_targetCount} times, +{_points} points each, +{_bonusPoints} bonus points)");
    }
}