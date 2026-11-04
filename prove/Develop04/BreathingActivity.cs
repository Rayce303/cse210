class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description)
    : base (name, description)
    {
        
    }

    public void RunActivity()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        Console.Clear();
        while (DateTime.Now < endTime)
        {
            RunCountdownMessage("Breathe In . . .", 4);
            RunCountdownMessage("Breathe Out . . .", 6);
        }
        DisplayEnding();
    }
}