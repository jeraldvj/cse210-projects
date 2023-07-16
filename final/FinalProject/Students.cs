using System;

public class Students{
    private int _studentID;
    private DateTime _startDate;
    private List<Certificates> _certificates = new List<Certificates>();
    private List<Courses> _courses = new List<Courses>();
    private string _name;
    private string _ciNumber;
    private DateTime _birthDate;
    private string _profession;

    public Students(){}

    public Students(int id, DateTime startDate, string name, string ci, DateTime birth, string profession){
        _studentID = id;
        _startDate = startDate;
        _name = name;
        _ciNumber = ci;
        _birthDate = birth;
        _profession = profession;
    }

    public void CreateStudents(int id){
        _studentID = id + 1;
        Console.WriteLine();
        Console.Write("Student Name: ");
        _name = Console.ReadLine();
        Console.Write("Student CI Number: ");
        _ciNumber = Console.ReadLine();
        Console.Write("Student Birth Date(dd/mm/yyyy): ");
        string user = Console.ReadLine();
        _birthDate = DateTime.Parse(user);
        Console.Write("Profession: ");
        _profession = Console.ReadLine();
        Console.Write("Start Date(dd/mm/yyyy): ");
        user = Console.ReadLine();
        _startDate = DateTime.Parse(user);
    }

    public void SetStudentID(int id){
        _studentID = id;
    }

    public int GetStudentID(){
        return _studentID;
    }

    public void AddCourse(Courses toAdd){
        _courses.Add(toAdd);
    }

    public void AddCertificate(Certificates toAdd){
        _certificates.Add(toAdd);
    }

    public string SaveToFile(){
        return $"{_studentID}:{_startDate.ToString("dd/MM/yyyy")},{_name},{_ciNumber},{_birthDate.ToString("dd/MM/yyyy")},{_profession}";
    }

    public void DisplayShortInfo(){
        Console.WriteLine($"ID: {_studentID} | Name: {_name} | CI: {_ciNumber} | Profession: {_profession} | Start Date: {_startDate.ToShortDateString()}");
    }

    public void DisplayInfo(){
        Console.WriteLine($"  ID: {_studentID}");
        Console.WriteLine($"  Name: {_name}");
        Console.WriteLine($"  CI: {_ciNumber}");
        Console.WriteLine($"  Birth Date: {_birthDate.ToShortDateString()}");
        Console.WriteLine($"  Profession: {_profession}");
        Console.WriteLine($"  Start Date: {_startDate.ToShortDateString()}");
        if (_courses.Count != 0 )
        {
            Console.WriteLine($" --------------------------------------------");
            Console.WriteLine($"  Courses Performed:");
            foreach (Courses course in _courses)
            {
                course.DisplayInfo();
            }
        }
        if (_certificates.Count != 0)
        {
            Console.WriteLine($" --------------------------------------------");
            Console.WriteLine($"  Certifications Performed:");
            foreach (Certificates certificate in _certificates)
            {
                certificate.DisplayInfo();
            }
        }
    }
}