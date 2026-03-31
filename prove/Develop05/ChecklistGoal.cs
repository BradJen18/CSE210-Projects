using System.Runtime.CompilerServices;

class ChecklistGoal : Goal
{
    private int _Count;
    private double _MilestonePoints;
    private int _Total;

    public int GetCount()
    {
        return _Count;
    }
    public void SetCount(int c)
    {
        _Count = c;
    }
    public double GetMPoints()
    {
        return _MilestonePoints;
    }
    public void SetMPoints(double MPoints)
    {
        _MilestonePoints = MPoints;
    }
    public int GetTotal()
    {
        return _Total;
    }
    public void SetTotal(int total)
    {
        _Total = total;
    }

    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string input = Console.ReadLine();
        SetGoalName(input);
        Console.Write("What is a short description of it? ");
        string input2 = Console.ReadLine();
        SetGoalDesc(input2);
        Console.Write("What is the ammount of points associated with this goal? ");
        string i3 = Console.ReadLine();
        double input3 = double.Parse(i3);
        SetGoalPoint(input3);
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string i4 = Console.ReadLine();
        int input4 = int.Parse(i4);
        SetCount(input4);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string i5 = Console.ReadLine();
        double input5 = double.Parse(i5);
        SetMPoints(input5);        
    }

    public override double RecordEntry()
    {   
        while (_Total != _Count)
        {
            _Total += 1;
            return GetGoalPoint();
        }
        SetIsComplete(true);
        return GetMPoints();
    }

    public override void DisplayGoal()
    {
        bool _IsComplete = GetIsComplete();
        string _GoalName = GetGoalName();
        string _GoalDesc = GetGoalDesc();

        if (_IsComplete == false)
        {
            Console.WriteLine($"[ ] {_GoalName} ({_GoalDesc}) -- Currently completed {_Total}/{_Count}");
        }
        else
        {
            Console.WriteLine($"[X] {_GoalName} ({_GoalDesc}) -- Currently completed {_Total}/{_Count}");   
        }
    }
    public ChecklistGoal()
    {
        CreateGoal();
    }
}