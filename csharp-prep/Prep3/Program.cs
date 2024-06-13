using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int number = int.Parse(userInput);

        // Console.WriteLine("What is your guess? ");
        // string userGuess = Console.ReadLine();
        // int guess = int.Parse(userGuess);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > number)
            {
                Console.WriteLine("Lower.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        }
}