using System;

public class Students{
    private int _studentID;
    private DateTime _startDate;
    private List<string> _certificates = new List<string>();
    private List<string> _courses = new List<string>();
    private string _name;
    private int _ciNumber;
    private DateTime _birthDate;
    private string _profession;

    public void Student(){
        _studentID++;
        _startDate = DateTime.Parse("12/08/2023");
        _name = "null";
        _ciNumber = 00;
        _birthDate = DateTime.Parse("12/08/1996");
        _profession = "Doctor";
    }

    public void SetStudentID(int id){
        _studentID = id;
    }

    public int GetStudentID(){
        return _studentID;
    }


    public void AddCourse(){

    }

    public void AddCertificate(){

    }

    public void DisplayInfo(){
        Console.Write($"ID: {_studentID} Date of Start: {_startDate} Name: {_name} CI: {_ciNumber} Birth Date: {_birthDate} Profession: {_profession}");
    }
}