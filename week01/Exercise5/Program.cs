using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        string userInput;
        int favorite;
        Console.Write("Please enter your favorite number: ");
        userInput = Console.ReadLine();
        favorite = int.Parse(userInput);
        return favorite;
    }
    static int SquareNumber(int n)
    {
        return (n * n);
    }
    static void DisplayResult(string name, int n)
    {
        Console.WriteLine(name + ", the square of your number is " + SquareNumber(n));
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
}