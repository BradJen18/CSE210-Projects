using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Brad","Math");
        Console.WriteLine(a1.GetSummary());

        MathAssignment ma1 = new MathAssignment("Brad","Math","7.1","3-7");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());

        WritingAssignment wa1 = new WritingAssignment("Brad","Math","The Great Gatsby");
        Console.WriteLine(wa1.GetSummary());
        Console.WriteLine(wa1.GetWritingInformation());
    }
}