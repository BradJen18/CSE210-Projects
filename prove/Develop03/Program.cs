using System;
using System.Collections.Concurrent;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Scripture scripture = new Scripture();

        Console.Clear();
        scripture.SetReference1("1 Nephi",11,17); // Set scripture Reference (if more than 1 verse switch "SetReference1" to "SetReference2")
        scripture.SetWords("And I said unto him: I know that he loveth his children; nevertheless, I do not know the meaning of all things."); // Set Scripture
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