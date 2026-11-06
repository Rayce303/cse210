class ReflectionActivity : BaseActivity
{
    Random someQuestion = new Random();
    List<string> _prompts = new List<string>
    {
        "What is something you have accomplished that you're proud of?",
        "When did you step outside your comfort zone?",
        "What is a mistake that taught you an important lesson?",
        "When have you shown kindness to someone who needed it?",
        "When did you help someone through a difficult situation?",
        "When have you made an effort to understand someone else's perspective?",
        "When did you make someone feel included or appreciated?",
        "When was a time you felt that God was helping you?"
    };
    
    List<string> _questions = new List<string>
    {
        "How did you feel about the outcome?",
        "What lessons did you take away from this experience?",
        "What did you discover about yourself?",
        "How has this experience affected your life since then?",
        "Why does this particular experience stand out in your memory?",
        "How might this experience influence your future decisions?",
        "What would you tell someone facing a similar situation?",
        "If you could revisit this experience, what would you want to remember most?"
    };

    public ReflectionActivity(string name, string description)
    : base (name, description)
    {
        
    }

    public void RunActivity()
    {
        StartActivity();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"{_prompts[someQuestion.Next(_prompts.Count)]}");
        Console.WriteLine("When you have something in mind, press ENTER.");
        string nothing = Console.ReadLine();

        DisplaySpinnerMessage("With that in mind, reflect on the following questions...", 6);
        Console.Clear();
        DisplaySpinnerMessage($"{_questions[someQuestion.Next(_questions.Count)]}", 10);
        DisplaySpinnerMessage($"{_questions[someQuestion.Next(_questions.Count)]}", 10);
        DisplayEnding();
    }
}