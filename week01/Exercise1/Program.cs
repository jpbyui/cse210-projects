using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        String name;
        String last_name;
        Console.Write("What is your name?");
        name = Console.ReadLine();
        Console.Write("What is your last name?");
        last_name = Console.ReadLine();
        Console.WriteLine("Your name is " + last_name + ", " + name + " " + last_name, ".");

    }
}