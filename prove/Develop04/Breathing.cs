using System;

class Breath : Activity
{
    public void BreathActivity()
    {   
        BeginningText();
        int duration = GetDuration();

        InteractBreath(duration);

        EndingText();

        Thread.Sleep(1000);
    }
    public void InteractBreath(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);  

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            
            Console.WriteLine();
            Console.Write($"Breath in... ");
            TimerIn();
            Console.WriteLine();
            Console.Write("Now breath out...");
            TimerOut();
            Console.WriteLine();

            currentTime = DateTime.Now;
        }
    }
    public void TimerIn()
    {
                Console.Write("[=    ]");
                Thread.Sleep(1000); 

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
                Console.Write("[==   ]");
                Thread.Sleep(1000);

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
                Console.Write("[===  ]"); 
                Thread.Sleep(1000);

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
                Console.Write("[==== ]");
                Thread.Sleep(1000);

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
                Console.Write("[=====]");
                Thread.Sleep(1000);

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
    }
    public void TimerOut()
    {
                Console.Write("[=====]");
                Thread.Sleep(1000); 

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
                Console.Write("[==== ]");
                Thread.Sleep(1000);

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
                Console.Write("[===  ]"); 
                Thread.Sleep(1000);

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
                Console.Write("[==   ]");
                Thread.Sleep(1000);

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
                Console.Write("[=    ]");
                Thread.Sleep(1000);

                Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b");
    }

    public Breath()
    {
        SetTitle("breathing activity");
        SetDesc("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetDuration(30);
    }
}