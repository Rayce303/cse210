class EternalGoal : BaseGoal
{
    public EternalGoal(string name, string description, int points, string goalType)
    : base (name, description, points, false, goalType)
    {}

    public EternalGoal() : base("Eternal Goal")
    {}

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetConsoleString()
    {
        return $"[ ] - {_goalType}: {_name} ({_description}), Points: {_points}";
    }

    public override string GetFileSystemString()
    {
        return $"{_goalType}#{_name}#{_description}#{_points}";
    }
}