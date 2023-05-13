using System;

public class Entry
{
    public string _prompt;
    public string _answer;
    public string _date;

    public void Display(){
        Console.WriteLine($"Date: {_date} — Prompt: {_prompt}\n{_answer}\n");
    }
}