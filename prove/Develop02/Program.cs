using System;

public class Program
{
    static void Main(string[] args)
    {   
        int user_input = -1;
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        do {
        const string MENU = "Please, select one of the following choices:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit";

        Console.WriteLine(MENU);
        user_input = int.Parse(Console.ReadLine());

        if (user_input == 1) //WRITE
        {
            Entry newEntry = new Entry();

            newEntry._date = DateTime.Today.ToString("MM/dd/yyyy");
            newEntry._prompt = prompt.getPrompt();
            Console.WriteLine($"{newEntry._prompt}");
            newEntry._answer = Console.ReadLine();
            journal._entries.Add(newEntry);
        }

        else if (user_input == 2) //DISPLAY
        {
            journal.displayJournal();
        }

        else if (user_input == 3) //SAVE
        {
            Console.WriteLine("What is the filename?");
            string file = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(file))
            {
                // You can add text to the file with the WriteLine method
                // You can use the $ and include variables just like with Console.WriteLine
                foreach (Entry entry in journal._entries)
                {
                    outputFile.WriteLine($"Date: {entry._date} - {entry._prompt} {entry._answer}");
                }     
            }
        }

        else if (user_input == 4) // LOAD
        {
            Console.WriteLine("Enter the name of the file: ");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                char[] separators = {':','-', '?'};
                Entry reader = new Entry();
                string[] parts = line.Split(separators);

                reader._date = parts[1].Trim();
                reader._prompt = parts[2].Trim() + "?";
                reader._answer = parts[3].Trim();
                journal._entries.Add(reader);
            }
        }
        } while (user_input != 5); // END WHEN USER QUITS (5)

    }
}   
