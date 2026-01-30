using System;
using System.ComponentModel;
using System.IO;
using System.Security.Permissions;

class Program // Bug in code: when you load a file, then save to it, it saves the old entries as seperate new entries.
{
    
    static void Main(string[] args)
    {
        string CodeFile = "Password.txt"; // Password to open program
        string Code = "";
        string[] stringCode = System.IO.File.ReadAllLines(CodeFile);
        foreach (string l in stringCode)
        {
            string [] parts = l.Split("");
            string lCode = parts[0];
            Code = lCode;
        }

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("What's the password?");
        string password = Console.ReadLine(); // input password
        while (password != Code)
        {
            Console.WriteLine("Wrong Password");
            Console.Write("Try again:");
            password = Console.ReadLine();
            
        }

        int choice = Menu();
        Journal Journal1 = new Journal();


        while (choice != 6)
        {
        
            PromptGen promptgen = new PromptGen();

            if (choice == 1) // Write entry
            {
                // Make an entry w/ date, and prompt     
                Entry Entry1 = new Entry();          
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Entry1._date = $"{dateText}";

                string prompt = promptgen.PickPrompt();
                Console.WriteLine($"{prompt}");
                Entry1._prompt = $"{prompt}"; 
                Entry1._input = Console.ReadLine();

                // Add entry to journal
                Journal1._entry.Add(Entry1);

                choice = Menu();
            }
            else if (choice == 2) // Display Journal
            {
                Journal1.DisplayJournal();            
                choice = Menu();
            }
            else if (choice == 3) // Load Journal
            {
                Console.WriteLine("What is the filename?");
                string name = Console.ReadLine();
                Journal1._entry.Clear();
                string [] lines = System.IO.File.ReadAllLines(name);
                foreach (string line in lines)
                {
                    string [] parts = line.Split("~~");
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._prompt = parts[1];
                    newEntry._input = parts[2];

                    Journal1._entry.Add(newEntry);
                }
                choice = Menu();
            }
            else if (choice == 4) // Save Journal
            {
                Console.WriteLine("What is the filename?");
                string name = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(name, true))
                {
                    foreach (Entry e in Journal1._entry)
                    {
                        outputFile.WriteLine($"{e._date}~~{e._prompt}~~{e._input}");        
                    }
                }

                choice = Menu();
            } 
            else if (choice == 5) // change password
            {
                Console.WriteLine("What do you want the new password to be?");
                using (StreamWriter outputFile = new StreamWriter(CodeFile))
                {
                    string newPassword = Console.ReadLine();
                    outputFile.WriteLine(newPassword);
                }
                choice = Menu();
            }
            else // Error message
            {
                Console.WriteLine($"The option {choice} is invalid");
                choice = Menu();
            }

        }
    }
            static int Menu()
        {
            Console.WriteLine("Please select one of the following(1-5):");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Change password");
            Console.WriteLine("6. Quit");            
            Console.WriteLine("What would you like to do?");
            string decision = Console.ReadLine();
            int choice = int.Parse(decision);
            return choice;
        }
}