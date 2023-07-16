using System;

public class Certificates{
    private string _certificateName;
    private DateTime _certificateDate;

    public Certificates(){
        Console.WriteLine();
        Console.Write("  Certificate Name: ");
        _certificateName = Console.ReadLine();
        Console.Write("  Certificate Date (dd/mm/yyyy): ");
        string date = Console.ReadLine();
        _certificateDate = DateTime.Parse(date);
    }

    public void DisplayInfo(){
            Console.WriteLine($"  - Certificate Name: {_certificateName} | Date: {_certificateDate.ToShortDateString()}");
    }
}