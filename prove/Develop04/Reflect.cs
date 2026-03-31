using System;

class Reflect : Activity
{
    public void ReflectActivity()
    {
        BeginningText();

        int duration = GetDuration();
        InteractReflect(duration);

        EndingText();

        Thread.Sleep(1000);
    }
    public void InteractReflect(int time)
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {PickPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in...");
        Timer();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);  

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            
            currentTime = DateTime.Now;
        }
    }
        
    public List<string> _prompts =
    [
        "Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."
    ];
    public string PickPrompt()
    {
        Random random = new Random();
        int number = random.Next(4);
        string _prompt = _prompts[number];
        return _prompt; 
    }

    public Reflect()
    {
        SetTitle("reflection activity");
        SetDesc("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetDuration(30);  
    }

}