using System;

public class Treatments{
    private string _name;
    private DateTime _date;
    private float _price;

    public Treatments(){
        Console.Write("Treatment Name: ");
        _name = Console.ReadLine();
        Console.Write("Treatment Date(dd/mm/yyyy): ");
        string user = Console.ReadLine();
        _date = DateTime.Parse(user);
        Console.Write("Treatment Price(BOB): ");
        user = Console.ReadLine();
        _price = float.Parse(user);
    }

    public void DisplayInfo(){
        Console.WriteLine($"    - Name: {_name}  Date: {_date.ToShortDateString()}  Price: {_price}");
    }
}