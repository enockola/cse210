using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Do you want to play Number Guesser? ");
        string response = Console.ReadLine();

        while (response.ToLower() != "no")
        {
            if (response.ToLower() == "yes")
            {
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(1, 100);

                int guess = 0;

                int count = 0;

                Console.WriteLine($"What is the magic number? {number}");

                while (guess != number)
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    count++;

                    if (guess > number)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {count} guesses");
                    }
                }
                Console.Write("Do you want to play again? ");
                response = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Response!");
                Console.Write("Do you want to play again? ");
                response = Console.ReadLine();
            }

        }
        Console.WriteLine("Thanks for playing Number Guesser!");
    }
}