class EternalGoal : Goal
{
    public override double RecordEntry()
    {
        return GetGoalPoint();
    }
    public EternalGoal()
    {
        CreateGoal();
    }
}