class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool status, string goalType)
    : base (name, description, points, status, goalType)
    {
        // this is called when reading data from a file
    }
    
    public SimpleGoal() : base("Simple Goal")
    {}

    public override int RecordEvent()
    {
        return MarkComplete();
    }
}