using System;
using System.Threading.Tasks.Dataflow;


class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._company = "Microsoft";
        Job1._startYear = 2019;
        Job1._endYear = 2022;
        Job1.DisplayJob();

        Job Job2 = new Job();
        Job2._jobTitle = "Manager";
        Job2._company = "Apple";
        Job2._startYear = 2022;
        Job2._endYear = 2023;
        Job2.DisplayJob();

        Resume Resume1 = new Resume();
        Resume1._name = "Bradley Jensen";
        Resume1._jobs.Add(Job1);
        Resume1._jobs.Add(Job2);
        Resume1.DisplayResume();
    }
}