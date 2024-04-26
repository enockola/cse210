using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int grade = int.Parse(gradePercent);
        int lastDigit = (grade % 10);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        // if statements to filter out A+, F+, and F-
        if (lastDigit >= 7 && grade < 93 && grade >59)
        {
            sign = "+";
        }
        else if (lastDigit < 3 && grade > 59)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade letter is '{letter}{sign}'");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }

        else
        {
            Console.WriteLine("You have failed this class! Better luck next time");
        }
    }
}