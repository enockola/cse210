public class Menu
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void AddGoal()
    {
        Console.Clear();
        Console.WriteLine("The type of goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("Write a short description of your goal:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter points for this goal:");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("Enter target count:");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points:");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not added.");
                break;
        }
    }
    
    public void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine("Displaying Goals");
        Thread.Sleep(1000);
        foreach (Goal goal in _goals)
        {
            goal.DisplayInfo();
            Thread.Sleep(1000);
        }
        ShowSpinnerAnimation(5);
    }


    public void SaveToFile(string filename)
    {
        Console.Clear();
        Console.WriteLine("Saving Goals");
        Thread.Sleep(1000);
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.Serialize());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the goals: {ex.Message}");
        }
        ShowSpinnerAnimation(5);
    }

    public void LoadFromFile(string filename)
    {
        Console.Clear();
        Console.WriteLine("Loading Goals");
        Thread.Sleep(1000);
        try
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("The specified file was not found.", filename);
            }

            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Goal goal = Goal.Deserialize(line);
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The specified file was not found.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"An error occurred while loading the goals: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        ShowSpinnerAnimation(5);
    }

    public void RecordGoalEvent()
    {
        Console.WriteLine("Select a goal to record event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayInfo();
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < _goals.Count)
        {
            Goal goal = _goals[choice];
            goal.RecordEvent();
            _score += goal.GetPoints();
            if (goal is ChecklistGoal checklistGoal && checklistGoal.GetIsCompleted())
            {
                _score += checklistGoal.GetPoints();
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Event not recorded.");
        }
    }

    public void ShowSpinnerAnimation(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");


        foreach (string item in animationStrings)
        {
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
