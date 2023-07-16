using System;

public class Courses{
    private string _courseName;
    private DateTime _courseDate;

    public Courses(){
        Console.WriteLine();
        Console.Write("  Course Name: ");
        _courseName = Console.ReadLine();
        Console.Write("  Course Date (dd/mm/yyyy): ");
        string date = Console.ReadLine();
        _courseDate = DateTime.Parse(date);
    }

    public void DisplayInfo(){
            Console.WriteLine($"  - Course Name: {_courseName} | Date: {_courseDate.ToShortDateString()}");
    }
}