using System.ComponentModel;

class SimpleGoal : Goal
{
    public override double RecordEntry()
    {
        SetIsComplete(true);
        return GetGoalPoint();
    }

    public SimpleGoal()
    {
        SetGoalName("happy");
        SetGoalDesc("be happy");
        SetGoalPoint(50);
        SetIsComplete(false);
        CreateGoal();
    }
    public SimpleGoal(string name, string desc, double point, bool isComplete)
    {
        SetGoalName(name);
        SetGoalDesc(desc);
        SetGoalPoint(point);
        SetIsComplete(isComplete);
    }

}