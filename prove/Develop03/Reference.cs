using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _initialVerse;
    private int _finalVerse = -1;

    public void SetBook(string book){
        _book = book;
    }

    public void SetChapter(int chapter){
        _chapter = chapter;
    }

    public void SetInitialVerse(int initialVerse){
        _initialVerse = initialVerse;
    }

    public void SetFinalVerse(int finalVerse){
        _finalVerse = finalVerse;
    }

    public string GetReference(){
        string text = _book + " " + _chapter + ":" + _initialVerse;
        if (_finalVerse != -1) // If there is a final verse, the middle dash, and the final verse are added to the reference.
        {
            text = text + "-" + _finalVerse;
        }
        return text;
    }
}