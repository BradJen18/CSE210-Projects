using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = 100;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<float> numbers = new List<float>();

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);

        }
        float sum = 0;
        float large = 0;
        foreach (float i  in numbers)
        {
           sum += i;
           if (large < i)
            {
                large = i;
            }    
        }
        float average = sum/(numbers.Count - 1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {large}");
    }
}