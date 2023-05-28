using System;

public class Scripture
{
    public List<Word> _word = new List<Word>();
    public Reference _reference = new Reference();

    public void DisplayScripture(){
        Console.Write($"{_reference.GetReference()} ");

        foreach (var word in _word)
        {
            Console.Write($"{word.GetWordContent()} ");
        }
    }

}