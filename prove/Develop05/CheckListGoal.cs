using System;

public class CheckListGoal: Goal{
    private int _bonus;
    private int _timesToComplete;
    private int _timesDone;
    
    public CheckListGoal(string typeOfGoal, string name, string description, int points, int bonus, int timesToComplete, int timesDone) : base (typeOfGoal, name, description, points){
        _typeOfGoal = typeOfGoal;
        _name = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _timesToComplete = timesToComplete;
        _timesDone = timesDone;
    }

    public CheckListGoal(){}

    public void CreateCheckListGoal(){
        _typeOfGoal = "ChecklistGoal";
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string user_Input = Console.ReadLine();
        _points = int.Parse(user_Input);
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        user_Input = Console.ReadLine();
        _timesToComplete = int.Parse(user_Input);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        user_Input = Console.ReadLine();
        _bonus = int.Parse(user_Input);
    }

    public override int RecordEvent(){
        _timesDone += 1;
        if (_timesDone == _timesToComplete)
        {
            _points += _bonus;
        }
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    public override string CheckMark(){
        if (_timesDone == _timesToComplete)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }

    public override string SaveToFile(){
        return $"{_typeOfGoal}:{_name},{_description},{_points},{_bonus},{_timesToComplete},{_timesDone}";
    }

    public override string DisplayListGoals(){
        return $". [{CheckMark()}] {_name} ({_description}) -- Currently completed: {_timesDone}/{_timesToComplete}";
    }
}