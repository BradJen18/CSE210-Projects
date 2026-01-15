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
        int squareNum = SquareNumber(num);
        DisplayResults(name, squareNum, year);        
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
        int favNumber = int.Parse(input);
        return favNumber;
    }
    static int PromptUserBirthYear()
    {
        Console.Write("Please enter your birth year: ");
        string input = Console.ReadLine();
        int birthYear = int.Parse(input);
        return birthYear;
    }
    static int SquareNumber(int favNumber)
    {
        int squareNum = favNumber * favNumber;
        return squareNum;
    }
    static void DisplayResults(string name, int squareNum, int birthYear)
    {
        int currentYear = 2026;
        Console.WriteLine($"{name}, The square of your number is {squareNum}");
        int age = currentYear - birthYear;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}