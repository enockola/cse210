
using System;

class Program
{
    static void Main(string[] args)
    {
        int duration;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMindfulness Acitvity Option:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity: ");
            string choice = Console.ReadLine();

            if (choice == "4")
                break;
            else if (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("\nInvalid choice. Please select again.");
            }
            else
            {
                Console.Write("\nHow long, in seconds, do you want to spend on this activity: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out duration))
                {
                    if (choice == "1")
                    {
                        BreathingActivity breathingActivity1 = new BreathingActivity("The Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                        breathingActivity1.StartBreathingActivity(duration);
                    }

                    if (choice == "2")
                    {
                        ReflectionActivity reflectionActivity1 = new ReflectionActivity("The Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                        reflectionActivity1.StartReflectionActivity(duration);
                    }

                    if (choice == "3")
                    {
                        ListingActivity listingActivity1 = new ListingActivity("The Listing Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                        listingActivity1.StartListingActivity(duration);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
