using System;

class Program
{
    static void Main(string[] args)
    {
        //USER INPUT
        Console.Write("What is your first name?");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name?");
        string last_name = Console.ReadLine();

        //OUTPUT
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}