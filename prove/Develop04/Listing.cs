using System;

class Listing : Activity
{
    public void ListeningActivity()
    {
        BeginningText();

        // Activity function

        EndingText();

        Thread.Sleep(1000);
    }
    public void InteractListening()
    {
        
    }

    public Listing()
    {
        SetTitle("Listing activity");
        SetDesc("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetDuration(30);
    }
}