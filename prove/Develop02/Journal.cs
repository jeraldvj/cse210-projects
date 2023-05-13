using System;
using System.IO; 

public class Journal
{
    public List<Entry> _entry = new List<Entry>();

    public void AddEntry(){
        Entry entry = new Entry();
        PromptGenerator promptSelected = new PromptGenerator();
        promptSelected.AddPrompt();
        entry._prompt = promptSelected.GeneratePrompt();
        Console.Write($"{entry._prompt}\n> ");
        entry._answer = Console.ReadLine();
        var date = DateTime.Now;
        entry._date = date.ToString("MM/dd/yyyy");

        _entry.Add(entry);
    }

    public void DisplayEntries(){
        foreach(Entry entry in _entry){
            entry.Display();
        }
    }

    public void LoadFromFile(string fileName){
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._answer = parts[2];

            _entry.Add(entry);
        }
    }

    public void SaveToFile(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entry){       
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._answer}");
            }
        }
    }
        
}