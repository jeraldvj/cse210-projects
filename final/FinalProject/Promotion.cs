using System;

public class Promotion{
    private string _name;
    private DateTime _startDate;
    private DateTime _endDate;
    private float _discount;
    private List<string> _treatmentsAvailables = new List<string>();

    public Promotion(string name, DateTime startDate, DateTime endDate, float discount){
        _name = name;
        _startDate = startDate;
        _endDate = endDate;
        _discount = discount;
    }

    public void DisplayInfo(){

    }

}