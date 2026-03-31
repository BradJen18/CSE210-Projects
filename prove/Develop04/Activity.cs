using System;

class Activity
{
    private string _title;
    private string _desc;
    private int _duration;

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDesc()
    {
        return _desc;
    }
    public void SetDesc(string desc)
    {
        _desc = desc;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void BeginningText()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title}");
        Console.WriteLine(" ");
        Console.WriteLine(_desc);
        Console.WriteLine(" ");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        
        Console.WriteLine("Get ready... ");
        Spinner(2);
    }
    public void EndingText()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Spinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_title}");
        Spinner(4);
    }
    public void Spinner(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);  

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
            {
                Console.Write("\b \b"); // Erase the \ character
                Console.Write("|"); // Replace it with the | character
                Thread.Sleep(250); // Wait 1/4 a second till next animation

                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(250);

                Console.Write("\b \b");
                Console.Write("-"); 
                Thread.Sleep(250);

                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(250);
                currentTime = DateTime.Now;
            
            }
        Console.Write("\b \b");                
    }
    public void Timer()
    {
                Console.Write("5");
                Thread.Sleep(1000); 

                Console.Write("\b \b");
                Console.Write("4");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("3"); 
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("2");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("1");
                Thread.Sleep(1000);

                Console.Write("\b \b");
    }
    public Activity()
    {
        _title = "";
        _desc = "";
        _duration = 0;
    }

} 
