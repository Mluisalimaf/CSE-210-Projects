using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    private int _startVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string Book
    {
        get {return _book;}
    }

    public int Chapter
    {
        get {return _chapter;}
    }

    public int Verse
    {
        get {return _verse;}
    }

    public int endVerse
    {
        get {return _endVerse;}
    }

    public int startVerse
    {
        get {return _startVerse;}
    }

    public string GetDisplayText()
    {
        if (_startVerse == _endVerse)
        {
            return $"{Book} {Chapter}: {startVerse}";
        }
        else
        {
            return $"{Book} {Chapter}: {startVerse}-{endVerse}";
        }
    }
}