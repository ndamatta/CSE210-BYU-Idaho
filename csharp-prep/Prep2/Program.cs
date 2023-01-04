using System;

class Program
{
    static void Main(string[] args)
    {   
        string letter = "";

        Console.Write("Please, insert your grade percentage: ");
        string user_input = Console.ReadLine();
        int grade = int.Parse(user_input);

        // Check user input and print grade
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }


        // Print grade (letter) and check if student passed or not, print message
        Console.WriteLine($"Your grade is : {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Well done! You passed");
        }
        else 
        {
            Console.WriteLine("You didn't pass, try again!");
        }
    }
}