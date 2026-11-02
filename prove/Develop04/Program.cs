using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity activity = new BaseActivity();
        // activity.RunCountdownMessage("Get Ready", 5);
        activity.DisplaySpinnerMessage("Well Done", 5);
    }
}