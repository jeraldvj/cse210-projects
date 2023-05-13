using System;

class Program
{
    static void Main(string[] args)
    {
        int num_option = 0;
        string fileName;
        Journal journal = new Journal();
        while (num_option != 5){
            switch(num_option){
                case 1:
                    journal.AddEntry();
                    break;
                case 2: 
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("What is the file name?");
                    fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName);
                    break;
                case 4:
                    Console.WriteLine("What is the file name?");
                    fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;
                }
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();
            num_option = int.Parse(option);
        }
    }
}