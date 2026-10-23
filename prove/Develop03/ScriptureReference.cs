class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int[] _verse;

    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        int[] something = {verse};
        _verse = something;
    }

    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        int[] something = {startVerse, endVerse};
        _verse = something;
    }

    public void DisplayScriptureReference()
    {
        Console.WriteLine(GetScriptureReference());
    }

    public string GetScriptureReference()
    {
        return GetScriptureReferenceString();
    }

    private string GetScriptureReferenceString()
    {
        string inStringForm;

        if (_verse.Length == 1)
        {
            inStringForm = $"{_bookName} {_chapter}:{_verse[0]}";
        }
        else
        {
            inStringForm = $"{_bookName} {_chapter}:{_verse[0]}-{_verse[1]}";
        }

        return inStringForm;
    }
}