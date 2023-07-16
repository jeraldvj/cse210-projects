using System;

public class Patients{
    protected int _patientID;
    protected string _membership;
    protected string _name;
    protected int _age;
    protected DateTime _birthDate;
    protected string _pathologicalHistory;
    protected string _generalPhysicalExamination;
    protected List<Treatments> _treatments = new List<Treatments>();

    public Patients(){}

    public Patients(int id, string membership, string name, int age, DateTime birth, string patho, string general){
        _patientID = id;
        _membership = membership;
        _name = name;
        _age = age;
        _birthDate = birth;
        _pathologicalHistory = patho;
        _generalPhysicalExamination = general;
    }

    public void CreatePatients(int id){
        _patientID = id + 1;
        _membership = "Normal";
        Console.WriteLine();
        Console.Write("Patient Name: ");
        _name = Console.ReadLine();
        Console.Write("Patient Birth Date(dd/mm/yyyy): ");
        string user = Console.ReadLine();
        _birthDate = DateTime.Parse(user);
        Console.Write("Patient Age: ");
        user = Console.ReadLine();
        _age = int.Parse(user);
        Console.Write("Patient Pathological History: ");
        _pathologicalHistory = Console.ReadLine();
        Console.Write("Patient General Physical Examination: ");
        _generalPhysicalExamination = Console.ReadLine();
    }

    public void SetPatientID(int id){
        _patientID = id;
    }

    public int GetPatientID(){
        return _patientID;
    }

    public void AddTreatmentToPatient(Treatments toAdd){
        _treatments.Add(toAdd);
    }

    public string SaveToFile(){
        return $"{_patientID}:{_membership},{_name},{_age},{_birthDate.ToString("dd/MM/yyyy")},{_pathologicalHistory},{_generalPhysicalExamination}";
    }

    public void DisplayShortInfo(){
        Console.WriteLine($"  ID: {_patientID} | Membership: {_membership} | Name: {_name} | Total Treatments: {_treatments.Count}");
    }

    public virtual void DisplayInfo(){
        Console.WriteLine($"  ID: {_patientID}");
        Console.WriteLine($"  Name: {_name}");
        Console.WriteLine($"  Age: {_age}");
        Console.WriteLine($"  Birth Date: {_birthDate.ToShortDateString()}");
        Console.WriteLine($" --------------------------------------------");
        Console.WriteLine($"  Membership: {_membership}");
        Console.WriteLine($"  Pathological History: {_pathologicalHistory}");
        Console.WriteLine($"  General Physical Examination: {_generalPhysicalExamination}");
        if (_treatments.Count != 0)
        {
            Console.WriteLine($" --------------------------------------------");
            Console.WriteLine($"  Treatments Performed:");
            foreach (Treatments treatment in _treatments)
            {
                treatment.DisplayInfo();
            }
        }
    }

}