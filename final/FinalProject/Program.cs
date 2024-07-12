using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Tasklist taskList = new Tasklist();
        CompletedTaskList completedTaskList = new CompletedTaskList();
        TaskOption taskOption = new TaskOption(taskList, completedTaskList);

        Console.WriteLine("Welcome to Task Manager!");
        Console.WriteLine("Manage your tasks well before it's due.\n");
        Thread.Sleep(1000);
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine($"You have {taskList.GetTaskCount()} tasks incompleted.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("   1. Add a new task");
            Console.WriteLine("   2. Remove a task");
            Console.WriteLine("   3. Update a task");
            Console.WriteLine("   4. Complete a task");
            Console.WriteLine("   5. View all tasks");
            Console.WriteLine("   6. View completed tasks");
            Console.WriteLine("   7. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    taskOption.AddNewTask();
                    break;
                case "2":
                    taskOption.RemoveTask();
                    break;
                case "3":
                    taskOption.UpdateTask();
                    break;
                case "4":
                    taskOption.CompleteTask();
                    break;
                case "5":
                    taskList.PrintAllTasks();
                    break;
                case "6":
                    completedTaskList.PrintAllCompletedTasks();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}