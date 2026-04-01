using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {   
        int choice = Menu();
        while (choice != 4)
        {
            Breath breath = new Breath();
            Reflect reflect = new Reflect();
            Listing listing = new Listing();
            Console.Clear();

            if (choice == 1) // Breathing activity
            {   
                breath.BreathActivity();
                choice = Menu();
            }
            else if (choice == 2) // Reflection activity
            {
                reflect.ReflectActivity();
                choice = Menu();
            }
            else if (choice == 3) // Listing activity
            {
                listing.ListeningActivity();
                choice = Menu();
            }
            else // Error message
            {
                Console.WriteLine($"The option {choice} is invalid");
                Thread.Sleep(3000);
                choice = Menu();
            }
        }
        Console.Clear();
    }
    static int Menu()
    {   
        int choice = 0;
        Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Start Breathing activity");
        Console.WriteLine(" 2. Start Reflecting activity");
        Console.WriteLine(" 3. Start Listing activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();
        choice = int.Parse(input);
        return choice;

    }
}
