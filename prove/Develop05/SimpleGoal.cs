using System;

public class SimpleGoal: Goal{

    public SimpleGoal(string typeOfGoal, string name, string description, int points, bool isComplete) : base (typeOfGoal, name, description, points){
        _typeOfGoal = typeOfGoal;
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }
    public SimpleGoal(){}
    
    public void CreateSimpleGoal(){
        _typeOfGoal = "SimpleGoal";
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string user_Input = Console.ReadLine();
        _points = int.Parse(user_Input);
    }

    public override int RecordEvent(){
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }
}