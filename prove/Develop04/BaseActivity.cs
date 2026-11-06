class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"{_description}");
        Console.Write("How many seconds would you like this activity to last? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        DisplaySpinnerMessage("Get Ready...  ", 5);
    }

    protected void DisplayEnding()
    {
        Console.Clear();
        DisplaySpinnerMessage("Well Done!   ", 5);
    }

    protected void RunCountdownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i >= 1; i--)
        {
            Console.Clear();
            Console.Write($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    protected void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message} ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("Oooo");
            Thread.Sleep(200);
            Console.Write("\b\b\b\b");
            Console.Write("oOoo");
            Thread.Sleep(200);
            Console.Write("\b\b\b\b");
            Console.Write("ooOo");
            Thread.Sleep(200);
            Console.Write("\b\b\b\b");
            Console.Write("oooO");
            Thread.Sleep(200);
            Console.Write("\b\b\b\b");
        }

        Console.Clear();
        Console.CursorVisible = true;
    }

    protected int GetDuration()
    {
        return _duration;
    }
}