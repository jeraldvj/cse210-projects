using System;

public class PatientsVIP: Patients
{
    private int _points;
    private DateTime _startMembershipDate;
    private DateTime _expiresIn;
    private bool _statusMembership;

    public PatientsVIP(){
        _points = 0;
        _startMembershipDate = DateTime.Parse("01-01-2022");
        _expiresIn = DateTime.Parse("12-31-2023");
        _statusMembership = true;
    }

    public override void DisplayInfo(){
        Console.Write($"Points: {_points} Start Membership VIP: {_startMembershipDate} Date of Expires: {_expiresIn} Membership Activated: {_statusMembership}");
    }

    public bool ChangeStatus(bool statusUpdated){
        return _statusMembership = statusUpdated;
    }
}