using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompt = new List<string>();
    private List<string> _promptQuestion = new List<string>();

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        AddToLists();       
    }

    private void AddToLists(){
        _prompt.Add("Think of a time when you stood up for someone else.");
        _prompt.Add("Think of a time when you did something really difficult.");
        _prompt.Add("Think of a time when you helped someone in need.");
        _prompt.Add("Think of a time when you did something truly selfless.");

        _promptQuestion.Add("Why was this experience meaningful to you?");
        _promptQuestion.Add("Have you ever done anything like this before?");
        _promptQuestion.Add("How did you get started?");
        _promptQuestion.Add("How did you feel when it was completed?");
        _promptQuestion.Add("What made this time different than other times when you were not as successful?");
        _promptQuestion.Add("What is your favorite thing about this experience?");
        _promptQuestion.Add("What could you learn from this experience that applies to other situations?");
        _promptQuestion.Add("What did you learn about yourself through this experience?");
        _promptQuestion.Add("How can you keep this experience in mind in the future?");
    }

    public string GetRandomPrompt(){
        Random randomGenerator = new Random();
        int randomChoose = randomGenerator.Next(0, _prompt.Count);
        return _prompt[randomChoose];
    }

    public string GetRandomQuestion(){
        Random randomGenerator = new Random();
        int randomChoose = randomGenerator.Next(0, _promptQuestion.Count);
        return _promptQuestion[randomChoose];
    }

    public void DisplayReflection(){
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string con = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        WaitTime(5);

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            Animation(15);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}