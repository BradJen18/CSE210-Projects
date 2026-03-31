class SimpleGoal : Goal
{
    public override double RecordEntry()
    {
        return GetGoalPoint();
    }

    public SimpleGoal()
    {
        CreateGoal();
    }

}