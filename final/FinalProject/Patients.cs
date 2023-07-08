using System;

public class Patients{
    private int _patientID;
    private string _name;
    private int _age;
    private DateTime _birthDate;
    private string _pathologicalHistory;
    private string _generalPhysicalExamination;
    private List<Treatments> _treatments = new List<Treatments>();

    public void CreatePatients(){
        _patientID++;  
        Console.Write("Patient Name: ");
        _name = Console.ReadLine();
        Console.Write("Patient Age: ");
        string user = Console.ReadLine();
        _age = int.Parse(user);
        Console.Write("Patient Birth Date: ");
        user = Console.ReadLine();
        _birthDate = DateTime.Parse(user);
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

    public virtual void DisplayInfo(){
        Console.WriteLine("Patient Info:");
        Console.WriteLine($"  ID: {_patientID} Name: {_name} Age: {_age} Birth Date: {_birthDate}");
        Console.WriteLine($"Treatments Performed:");
    }

}