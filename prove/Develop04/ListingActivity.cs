class ListingActivity : BaseActivity
{
    Random random = new Random();
    List<string> _allDaQuestions = new List<string>
    {
        "What are you grateful for today?",
        "Who has made you laugh recently?",
        "Who has taught you something valuable?",
        "What are some things you look forward to?",
        "What are some things that help you relax?",
        "What are some things you're good at?",
        "What are some new things you've tried?",
        "What are some accomplishments you're proud of?",
        "What are some things you enjoy about your daily routine?",
        "What are some songs that put you in a good mood?",
        "What are some things you're excited about in the future?",
        "What are some things you admire about Jesus Christ?"
    };

    public ListingActivity(string name, string description)
    : base (name, description)
    {
        
    }
    public void RunActivity()
    {
        int numberOfAnswers = 0;
        StartActivity();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplaySpinnerMessage($"--- {_allDaQuestions[random.Next(_allDaQuestions.Count)]} ---", 10);
        Console.WriteLine("GO!!!");

        DateTime endTime = DateTime.Now.AddSeconds(20);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string whatever = Console.ReadLine();
            ++ numberOfAnswers;
        }

        Console.Clear();
        DisplaySpinnerMessage($"Good job! You listed {numberOfAnswers} items!", 7);
        DisplayEnding();
    }
}