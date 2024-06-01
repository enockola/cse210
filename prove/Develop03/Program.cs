using System;

class Program
{
    static void Main()
    {

        string referenceText = "Proverbs 3:5-6";
        string scriptureText = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        Scripture scripture = new Scripture(referenceText, scriptureText);

        while (true)
        {
            ClearScreen();
            scripture.Display();

            Console.WriteLine("\nPress Enter to continue or type 'quit' to end: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            // I added an end program note if all words are hidden
            if (scripture.AllWordsHidden())
            {
                ClearScreen();
                scripture.Display();
                Console.WriteLine("\nAll words are hidden. Program will now end.");
                break;
            }
        }
    }

    static void ClearScreen()
    {
        Console.Clear();
    }
}
