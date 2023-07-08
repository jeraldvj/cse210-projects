using System;

public class Inventory{
    private int _inventoryID;
    private string _name;
    private int _amount;
    private string _notify;

    public Inventory(){
        _inventoryID++;
        _name = "null";
        _amount = 10;
        _notify = "A lot";
    }

    public void SetInventoryID(int id){
        _inventoryID = id;
    }

    public int GetInventoryID(){
        return _inventoryID;
    }

    public virtual void DisplayInfo(){
        Console.Write($"ID: {_inventoryID} Name: {_name} Amount: {_amount} Notify: {_notify}");
    }
}
