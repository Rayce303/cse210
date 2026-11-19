class Goals
{
    private List<BaseGoal> _goals;
    private string _filename;
    private int _totalScore;

    public Goals()
    {
        _goals = new List<BaseGoal>();
        _totalScore = 0;
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void LoadGoals()
    {
        ObtainFileName();

        string[] fileText = File.ReadAllLines(_filename);
        _goals.Clear();

        foreach (string line in fileText)
        {
            string[] pieces = line.Split("#");

            // it's formatted like: type # name # description # points # status
            if (pieces[0] == "Simple Goal")
            {
                SimpleGoal goal = new SimpleGoal(pieces[1], pieces[2], int.Parse(pieces[3]), bool.Parse(pieces[4]), pieces[0]);
                _goals.Add(goal);
            }
            // this is formatted: type # name # desc # points
            else if (pieces[0] == "Eternal Goal")
            {
                EternalGoal goal = new EternalGoal(pieces[1], pieces[2], int.Parse(pieces[3]), pieces[0]);
                _goals.Add(goal);
            }
            // this format: type # name # description # points # complete # timesCompleted # maxGoals # bonusPoints;
            else
            {
                ChecklistGoal goal = new ChecklistGoal(
                    pieces[1],
                    pieces[2],
                    int.Parse(pieces[3]),
                    bool.Parse(pieces[4]),
                    pieces[0],
                    int.Parse(pieces[5]),
                    int.Parse(pieces[6]),
                    int.Parse(pieces[7])
                );
                _goals.Add(goal);
            }
        }
    }

    public void SaveGoals()
    {
        ObtainFileName();
        List<string> savedStuff = new List<string>();

        foreach (BaseGoal goal in _goals)
        {
            savedStuff.Add(goal.GetFileSystemString());
        }

        File.WriteAllLines(_filename, savedStuff);
    }

    public void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine("Your goals are:");

        foreach(BaseGoal individualGoal in _goals)
        {
            Console.WriteLine(individualGoal.GetConsoleString());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
        Console.WriteLine();
    }

    public void RecordEvent()
    {
        Console.WriteLine("Your goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        int points = _goals[choice - 1].RecordEvent();

        _totalScore += points;

        Console.WriteLine($"Yay! You have earned {points} points!");
    }

    private void ObtainFileName()
    {
        Console.Write("Enter the name of the file: ");
        _filename = Console.ReadLine();
    }
}