using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        //Console.WriteLine("What is the magic number?");
        string userInput = Console.ReadLine();

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessUser;
        Boolean answer = false;
        while (!answer)
        {
            Console.WriteLine("What is your guess?");
            userInput = Console.ReadLine();
            guessUser = int.Parse(userInput);
            if (guessUser == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                answer = true;
            }
            else
            {
                if (guessUser > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            }
        }
    }
}