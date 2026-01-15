using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int year = PromptUserBirthYear();
        int squarenum = SquareNumber(num);
        DisplayResults(name, squarenum, year);        
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int favnumber = int.Parse(input);
        return favnumber;
    }
    static int PromptUserBirthYear()
    {
        Console.Write("Please enter your birth year: ");
        string input = Console.ReadLine();
        int birthyear = int.Parse(input);
        return birthyear;
    }
    static int SquareNumber(int favnumber)
    {
        int squarenum = favnumber * favnumber;
        return squarenum;
    }
    static void DisplayResults(string name, int squarenum, int birthyear)
    {
        int currentYear = 2026;
        Console.WriteLine($"{name}, The square of your number is {squarenum}");
        int age = currentYear - birthyear;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}