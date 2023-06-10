using System;

public class ListingActivity : Activity
{
    private List<string> _userInput = new List<string>();
    private List<string> _questions = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        AddToQuestions();
    }

    private void AddToQuestions(){
        _questions.Add("Who are people that you appreciate?");
        _questions.Add("What are personal strengths of yours?.");
        _questions.Add("Who are people that you have helped this week?");
        _questions.Add("When have you felt the Holy Ghost this month?");
        _questions.Add("Who are some of your personal heroes?");
    }

    public string GetRandomQuestion(){
        Random randomGenerator = new Random();
        int randomChoose = randomGenerator.Next(0, _questions.Count);
        return _questions[randomChoose];
    }

    public void SaveAnswers(){
        Console.Write("> ");
        string userInput = Console.ReadLine();
        _userInput.Add(userInput);
    }

    public void DisplayListing(){
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomQuestion()} ---");
        Console.Write("You may begin in: ");
        WaitTime(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            SaveAnswers();
        }
        Console.WriteLine($"You listed {_userInput.Count} items!\n");
    }
}