using System;
using System.IO; 

public class File
{
    private int _total;

    public void SaveToFile(string fileName, int totalPoints, List<Goal> listOfGoals){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{totalPoints}");
            foreach(Goal goal in listOfGoals){       
                outputFile.WriteLine(goal.SaveToFile());
            }
        }
    }

    public List<Goal> LoadFromFile(string fileName){

        List<Goal> goals = new List<Goal>();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int first = 0;
        foreach (string line in lines)
        {
            char[] separator = {':',','};
            string[] parts = line.Split(separator);
            if (first == 0)
            {
                _total = int.Parse(parts[0]);
                first = 1;
            }

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal(parts[0],parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                goals.Add(sg);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal(parts[0],parts[1],parts[2],int.Parse(parts[3]));
                goals.Add(eg);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                CheckListGoal clg = new CheckListGoal(parts[0],parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]));
                goals.Add(clg);
            }
        }
        return goals;
    }

    public int NewData(){
        return _total;
    }
}