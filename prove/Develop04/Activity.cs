using System;

public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void InputDuration(){
        Console.Write("How long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
    }

    public void Animation(int duration){
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i >= animation.Count)
            {
                i = 0;
            }
        }

    }

    public void WaitTime(int seconds){
        List<string> numbers = new List<string>();
        for (int c = 1; c <= seconds; c++)
        {
            string str = c.ToString();
            numbers.Add(str);
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            for (int i = seconds-1; i >= 0; i--)
            {
                string s = numbers[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public void StartingMessage(){
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        InputDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(10);
        Console.WriteLine();
    }

    public void EndingMessage(){
        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Animation(10);
    }
}