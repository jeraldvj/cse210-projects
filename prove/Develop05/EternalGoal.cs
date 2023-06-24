using System;

public class EternalGoal: Goal{
    
    public EternalGoal(string typeOfGoal, string name, string description, int points) : base (typeOfGoal, name, description, points){
        _typeOfGoal = typeOfGoal;
        _name = name;
        _description = description;
        _points = points;
    }

    public EternalGoal(){}

    public void CreateEternalGoal(){
        _typeOfGoal = "EternalGoal";
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string user_Input = Console.ReadLine();
        _points = int.Parse(user_Input);
    }

    public override int RecordEvent(){
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    public override string SaveToFile(){
        return $"{_typeOfGoal}:{_name},{_description},{_points}";
    }
}