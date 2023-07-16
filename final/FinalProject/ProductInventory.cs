using System;

public class ProductInventory: Inventory{
    private DateTime _dateOfExpiry;
    private DateTime _elaborationDate;
    private int _mlQuantity;
    private int _quantityInsidePackage;

    public ProductInventory(int id) : base(id) {
        Console.Write("  Date of Expiry: ");
        string date = Console.ReadLine();
        _dateOfExpiry = DateTime.Parse(date);
        Console.Write("  Elaboration Date: ");
        date = Console.ReadLine();
        _elaborationDate = DateTime.Parse(date);
        Console.Write("  Quantity (ml): ");
        string data = Console.ReadLine();
        _mlQuantity = int.Parse(data);
        Console.Write("  Quantity Inside Package (units): ");
        data = Console.ReadLine();
        _quantityInsidePackage = int.Parse(data);
    }

    public override void DisplayInfo(){
        Console.WriteLine($"  ID: {_inventoryID} | Name: {_name} | Amount: {_amount} | Notify: {_notify}");
        Console.WriteLine($"  - Expiry: {_dateOfExpiry.ToShortDateString()} | Elaborated: {_elaborationDate.ToShortDateString()} | ml: {_mlQuantity} | InPackage: {_quantityInsidePackage}");
    }
}