using System;
using System.Collections.Concurrent;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is the book? (example: 1 Nephi)");
        string input1 = Console.ReadLine();
        Console.WriteLine("What is the chapter? ");
        string input2 = Console.ReadLine();
        int i2 = int.Parse(input2);
        Console.WriteLine("What is the verse? ");
        string input3 = Console.ReadLine();
        int i3 = int.Parse(input3);
        Console.WriteLine("Is there an end verse? Y/N");
        string input4 = Console.ReadLine();
        int i5 = 0;
        if (input4 == "Y" || input4 == "yes" || input4 == "Yes")
        {
            Console.WriteLine("What is the verse? ");
            string input5 = Console.ReadLine();
            i5 = int.Parse(input5);
        }

        Console.WriteLine("What is the scripture?");
        string input6 = Console.ReadLine(); // "And I said unto him: I know that he loveth his children; nevertheless, I do not know the meaning of all things."

        Scripture scripture = new Scripture();

        Console.Clear();
        if (input4 == "Y" || input4 == "yes" || input4 == "Yes")
        {
            scripture.SetReference2(input1,i2,i3,i5);
        }
        else
        {
            scripture.SetReference1(input1,i2,i3); 
        }
        scripture.SetWords(input6); // Set Scripture
        scripture.RenderAll();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();


        int num = scripture.CompleteHide();
        while (num > 0 && input != "quit")
        {
            Console.Clear();
            scripture.HideWords();
            scripture.RenderAll();
            input = Console.ReadLine();
            num = scripture.CompleteHide();
            Console.Clear();
        }
        Console.Clear();
    }
}