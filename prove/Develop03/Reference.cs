using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
        _book = "Alma";
        _chapter = 37;
        _verse = 37;
    }

    private Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    private Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        string refText;
        if (_endVerse != 0) {
            refText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        } else {
            refText = $"{_book} {_chapter}:{_verse}";
        }
        return refText;
    }
}