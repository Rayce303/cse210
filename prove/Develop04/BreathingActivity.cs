class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description)
    : base (name, description)
    {
        
    }

    public void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(15);

        while (DateTime.Now < endTime)
        {
            RunCountdownMessage("Breathe In . . .", 4);
            RunCountdownMessage("Breathe Out . . .", 6);
        }
    }
}