using System;

public class Program
{
    public static void Main(string[] args)
    {
        Menu menuOption = new Menu();
        bool running = true;

        while (running)
        {
            Console.Clear();
            menuOption.DisplayScore();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("   1. Create a new goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    menuOption.AddGoal();
                    break;
                case "2":
                    menuOption.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    menuOption.SaveToFile(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    menuOption.LoadFromFile(loadFilename);
                    break;
                case "5":
                    menuOption.RecordGoalEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}