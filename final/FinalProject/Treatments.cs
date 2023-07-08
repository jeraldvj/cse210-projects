using System;

public class Treatments{
    private int _treatmentID;
    private string _name;
    private DateTime _date;
    private string _pictureBefore;
    private string _pictureAfter;
    private string _segmentalPhysicalExamination;
    private float _price;

    public Treatments(int id, string name, DateTime date, string pictureB, string pictureA, string sPE, float price){
        _treatmentID =  id;
        _name = name;
        _date = date;
        _pictureBefore = pictureB;
        _pictureAfter = pictureA;
        _segmentalPhysicalExamination = sPE;
        _price = price;
    }
}