abstract class BaseGoal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _complete;
    protected string _goalType;
    public BaseGoal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = status;
        _goalType = goalType;
    }
    public BaseGoal(string goalType)
    {
        SetGoalName();
        SetGoalDescription();
        SetGoalPoints();
        _complete = false;
        _goalType = goalType;
    }

    protected void SetGoalName()
    {
        Console.Write("Please enter the name of your goal: ");
        _name = Console.ReadLine();
    }

    protected void SetGoalDescription()
    {
        Console.Write("Please enter the description of your goal: ");
        _description = Console.ReadLine();
    }

    protected void SetGoalPoints()
    {
        Console.Write($"Please enter the number of points for your goal {_name}: ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual string GetConsoleString()
    {
        string completeString = " ";
        if (_complete)
            completeString = "X";

        return $"[{completeString}] - {_goalType}: {_name} ({_description}), Points: {_points}";
    }

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}#{_name}#{_description}#{_points}#{_complete}";
    }

    public int MarkComplete()
    {
        _complete = true;
        return _points;
    }

    public abstract int RecordEvent();
}