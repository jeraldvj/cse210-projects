using System;

public class PatientsVIP: Patients
{
    private int _points;
    private DateTime _startMembershipDate;
    private DateTime _expiresIn;
    private bool _statusMembership;

    public PatientsVIP(){
        _membership = "VIP";
        _statusMembership = true;
    }

    public void CreateMembership(){
        Console.Write("Points: ");
        string user = Console.ReadLine();
        _points = int.Parse(user);
        Console.Write("Start Membership Date(dd/mm/yyyy): ");
        user = Console.ReadLine();
        _startMembershipDate = DateTime.Parse(user);
        Console.Write("End Membership Date(dd/mm/yyyy): ");
        user = Console.ReadLine();
        _expiresIn = DateTime.Parse(user);
    }

    public override void DisplayInfo(){
        Console.WriteLine($"  ID: {_patientID}");
        Console.WriteLine($"  Name: {_name}");
        Console.WriteLine($"  Age: {_age}");
        Console.WriteLine($"  Birth Date: {_birthDate.ToShortDateString()}");
        Console.WriteLine($" --------------------------------------------");
        Console.WriteLine($"  Membership: {_membership}");
        Console.WriteLine($"  + Points: {_points} | Membership Activated: {_statusMembership}");
        Console.WriteLine($"    Start Membership: {_startMembershipDate.ToShortDateString()} | Date of Expires: {_expiresIn.ToShortDateString()}");
        Console.WriteLine($"  Pathological History: {_pathologicalHistory}");
        Console.WriteLine($"  General Physical Examination: {_generalPhysicalExamination}");
        Console.WriteLine($" --------------------------------------------");
        if (_treatments.Count != 0)
        {
            Console.WriteLine($"  Treatments Performed:");
            foreach (Treatments treatment in _treatments)
            {
                treatment.DisplayInfo();
            }
        }
    }

    public bool ChangeStatus(bool statusUpdated){
        return _statusMembership = statusUpdated;
    }
}