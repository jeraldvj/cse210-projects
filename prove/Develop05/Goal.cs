using System;

public class Goal{
    protected string _typeOfGoal;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete = false;

    public Goal(string typeOfGoal, string name, string description, int points){
        _typeOfGoal = typeOfGoal;
        _name = name;
        _description = description;
        _points = points;
    }
    public Goal(){}

    public string GetName(){
        return _name;
    }

    public virtual int RecordEvent(){
        return 0;
    }

    public virtual string CheckMark(){
        if (_isComplete == true)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }


    public virtual string DisplayListGoals(){
        return $". [{CheckMark()}] {_name} ({_description})";
    }

    public virtual string SaveToFile(){
        return $"{_typeOfGoal}:{_name},{_description},{_points},{_isComplete}";
    }
}