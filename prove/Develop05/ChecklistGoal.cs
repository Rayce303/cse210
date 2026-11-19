class ChecklistGoal : BaseGoal
{
    private int _timesCompleted;
    private int _maxGoals;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, bool status, string goalType, int completions, int max, int bonus)
    : base (name, description, points, status, goalType)
    {
        _timesCompleted = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }

    public ChecklistGoal() : base("Checklist Goal")
    {
        ObtainMaxGoal();
        ObtainBonusPoints();
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        int allDaPoints = _points;

        if (_timesCompleted == _maxGoals)
        {
            allDaPoints += _bonusPoints;
            MarkComplete();
        }

        return allDaPoints;
    }

    public override string GetConsoleString()
    {
        string completeString = " ";
        if (_complete)
            completeString = "X";

        return $"[{completeString}] - {_goalType}: {_name} ({_description}), Points: {_points} -- Completed {_timesCompleted}/{_maxGoals}";
    }

    public override string GetFileSystemString()
    {
        return $"{_goalType}#{_name}#{_description}#{_points}#{_complete}#{_timesCompleted}#{_maxGoals}#{_bonusPoints}";
    }

    private void ObtainMaxGoal()
    {
        Console.Write($"How many times do you wanna complete this goal? ");
        _maxGoals = int.Parse(Console.ReadLine());
    }

    private void ObtainBonusPoints()
    {
        Console.Write($"How many points is this goal worth once it's done? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
}