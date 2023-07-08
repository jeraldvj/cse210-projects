using System;

public class ProductInventory: Inventory{
    private DateTime _dateOfExpiry;
    private DateTime _elaborationDate;
    private int _mlQuantity;
    private int _quantityInsidePackage;

    public ProductInventory(){
        _dateOfExpiry = DateTime.Parse("24-12-2023");
        _elaborationDate = DateTime.Parse("01-01-2023");
        _mlQuantity = 100;
        _quantityInsidePackage = 6;
    }

    public override void DisplayInfo(){
        Console.Write($"Date of Expiry: {_dateOfExpiry} Elaboration Date: {_elaborationDate} ml quantity: {_mlQuantity} Quantity Inside Packege: {_quantityInsidePackage}");

    }
}