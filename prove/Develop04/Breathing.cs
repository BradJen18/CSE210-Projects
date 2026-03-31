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
            Timer();
            Console.WriteLine();
            Console.Write("Now breath out...");
            Timer();
            Console.WriteLine();

            currentTime = DateTime.Now;
        }
    }

    public Breath()
    {
        SetTitle("breathing activity");
        SetDesc("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetDuration(30);
    }
}