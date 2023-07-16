using System;

public class Inventory{
    protected int _inventoryID;
    protected string _name;
    protected int _amount;
    protected string _notify;

    public Inventory(int id, string name, int amount, string notify){
        _inventoryID = id;
        _name = name;
        _amount = amount;
        _notify = notify;
    }

    public Inventory(int id){
        _inventoryID = id + 1;
        Console.Write("  Product Name: ");
        _name = Console.ReadLine();
        Console.Write("  Amount: ");
        string user = Console.ReadLine();
        _amount = int.Parse(user);
        NotifyAmount(_amount);
    }

    public void SetInventoryID(int id){
        _inventoryID = id;
    }

    public int GetInventoryID(){
        return _inventoryID;
    }

    public void SetAmount(int amount){
        _amount = amount;
    }

    public int GetAmount(){
        return _amount;
    }

    public void NotifyAmount(int amount){
        if (amount >= 10)
        {
            _notify = "Enough in Stock";
        }
        else if(amount >=5)
        {
            _notify = "Little in Stock";
        }
        else if(amount <= 1)
        {
            _notify = "Renew";
        }
    }

    public string SaveToFile(){
        return $"{_inventoryID}:{_name},{_amount},{_notify}";
    }

    public virtual void DisplayInfo(){
        Console.WriteLine($"  ID: {_inventoryID} | Name: {_name} | Amount: {_amount} | Notify: {_notify}");
    }
}
