using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GeneratePrompt(){
        Random randomGenerator = new Random();
        int randomOption = randomGenerator.Next(0, 5);
        
        return _prompts[randomOption];
    }

    public void AddPrompt(){
        string question0 = "Who was the most interesting person I interacted with today?";
        string question1 = "What was the best part of my day?";
        string question2 = "How did I see the hand of the Lord in my life today?";
        string question3 = "What was the strongest emotion I felt today?";
        string question4 = "If I had one thing I could do over today, what would it be?";

        _prompts.Add(question0);
        _prompts.Add(question1);
        _prompts.Add(question2);
        _prompts.Add(question3);
        _prompts.Add(question4);
    }
}