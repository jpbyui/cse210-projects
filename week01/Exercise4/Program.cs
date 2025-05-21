using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        int total = 0;
        int max = 0;
        double avg = 0.0;
        List<int> numbers = new List<int>();
        string userInput;
        int newNumber;
        bool isZero = false;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (!isZero)
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            newNumber = int.Parse(userInput);
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
                if (newNumber > max)
                {
                    max = newNumber;
                }
            }
            else
            {
                isZero = true;
            }

        }
        if (numbers.Count > 0)
        {
            foreach (int n in numbers)
            {
                total = total + n;
            }
            avg = total / numbers.Count;
        }
        Console.WriteLine("The sum is: " + total);
        Console.WriteLine("The average is: " + avg);
        Console.WriteLine("The largest number is: " + max);
    }
}