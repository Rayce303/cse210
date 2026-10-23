class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        ScriptureReference myRef = new ScriptureReference(bookName, chapter, verse);
        _reference = myRef;
        _words = ConvertToWords(text);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        ScriptureReference myRef = new ScriptureReference(bookName, chapter, startVerse, endVerse);
        _reference = myRef;
        _words = ConvertToWords(text);
    }

    public bool HideSomeWords()
    {
        Random random = new Random();
        int goingToBeHidden = 0;

        while (goingToBeHidden < 3 && NumberOfHiddenWords() < _words.Count)
        {
            Word randomWord = _words[random.Next(_words.Count)];

            if (randomWord.IsHidden() == false)
            {
                randomWord.Hide();
                goingToBeHidden += 1;
            }
        }

        if (NumberOfHiddenWords() < _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ShowScripture()
    {
        Console.Clear();
        _reference.DisplayScriptureReference();
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    private int NumberOfHiddenWords()
    {
        int hidden = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hidden += 1;
            }
        }
        return hidden;
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();

        string[] words = text.Split(" ");
        foreach (string word in text.Split(" "))
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }

        return tempWords;
    }
}