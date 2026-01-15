using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        int guess = 0;

        Console.WriteLine(number); // Prints the random number generated. Used to test the code.


        while (guess != number)
        {
            Console.Write("what is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        Console.Write("You guessed it!");
    }
}