using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Grade porcentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter_grade = "F";

        if (grade >= 90)
        {
            letter_grade = "A";
        }
        else
        {
            if (grade >= 80)
            {
                letter_grade = "B";
            }
            else
            {
                if (grade >= 70)
                {
                    letter_grade = "C";
                }
                else
                {
                    if (grade >= 60)
                    {
                        letter_grade = "D";
                    }
                }
            }
        }
        Console.WriteLine(letter_grade);

    }
}