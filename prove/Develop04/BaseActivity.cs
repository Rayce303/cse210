class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void StartActivity()
    {
        
    }

    protected void DisplayEnding()
    {
        
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
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }

        Console.Clear();
        Console.CursorVisible = true;
    }

    // protected void StartTime()
    // {
        
    // }

    // protected bool HasTimerExpired()
    // {
        
    // }

    // protected void ObtainDuration()
    // {
        
    // }

    // protected string GetPromptString(List<FlaggedString>)
    // {
        
    // }
}