using System;
using System.Runtime.CompilerServices;

class Listing : Activity
{
    public void ListeningActivity()
    {
        BeginningText();

        int duration = GetDuration();
        InteractListing(duration);

        EndingText();

        Thread.Sleep(1000);
    }
    public void InteractListing(int time)
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {PickPrompt()} ---");
        Console.Write("You may begin in: ");
        Timer();
        Console.WriteLine();
        int _responses = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);  

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.ReadLine();
            _responses += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_responses} items!");
    }
    private List<string> _prompts =
    [
        "Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"
    ];
    public string PickPrompt()
    {
        Random random = new Random();
        int number = random.Next(4);
        string _prompt = _prompts[number];
        return _prompt; 
    }

    public Listing()
    {
        SetTitle("Listing activity");
        SetDesc("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetDuration(30);
    }
}