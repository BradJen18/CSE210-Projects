class Goal
{
    private string _GoalName;
    private string _GoalDesc;
    private double _GoalPoint;
    private bool _IsComplete;

    public string GetGoalName()
    {
        return _GoalName;
    }
    public void SetGoalName(string name)
    {
        _GoalName = name;
    }
    public string GetGoalDesc()
    {
        return _GoalDesc;
    }
    public void SetGoalDesc(string desc)
    {
        _GoalDesc = desc;
    }
    public double GetGoalPoint()
    {
        return _GoalPoint;
    }
    public void SetGoalPoint(double point)
    {
        _GoalPoint = point;
    }
    public bool GetIsComplete()
    {
        return _IsComplete;
    }
    public void SetIsComplete(bool input)
    {
        _IsComplete = input;
    }
    public virtual void DisplayGoal()
    {
        if (_IsComplete == false)
        {
            Console.WriteLine($"[ ] {_GoalName} ({_GoalDesc})");
        }
        else
        {
            Console.WriteLine($"[X] {_GoalName} ({_GoalDesc})");   
        }
    }

    public virtual void CreateGoal()
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
        SetIsComplete(false);
    }

    public virtual double RecordEntry()
    {
        SetIsComplete(true);
        return GetGoalPoint();
    }
    public Goal()
    {
        CreateGoal();
    }
}