class JournalEntry
{
    Random rand = new Random();

    public string _date;
    public string _prompt;
    public string _response;

    List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What part of my day would I like to redo? ",
        "If I had more time today, what would I do? ",
        "What is something I learned today? "
    };

    public void DisplayEntry()
    {
        Console.Write($"{_date}, ");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_response}");
    }

    //This one is for when the user makes a new entry.
    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToString("MMMM d, yyyy");

        int randomIndex = rand.Next(prompts.Count);
        _prompt = prompts[randomIndex];

        Console.Write($"{_prompt}");
        _response = Console.ReadLine();
    }

    //This one is for when the Journal class calls it.
    public void CreateJournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public string CreateFileSystemString()
    {
        string outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }
}