using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number!");
            string userGuess = Console.ReadLine();
            int secretNumber = 42;
            int userGuessInt = Int32.Parse(userGuess);

            

            if (userGuessInt == secretNumber)
            {
                Console.WriteLine("Are you Douglas Adams?");
            }
            else
            {
                Console.WriteLine("Sorry, try again.");
            }

        }
    }
}
