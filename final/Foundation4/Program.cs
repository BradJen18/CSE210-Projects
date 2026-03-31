using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();
        activity.Add(new Running("3/31/2026",30,"Running",10));
        activity.Add(new Cycling("3/25/2026",60,"Cycling",20));
        activity.Add(new Swimming("2/14/2026",20,"Swimming",32));

        Console.WriteLine("Recorded Activities:");
        foreach (Activity a in activity)
        {
            a.GetSummary();
        }
    }
}