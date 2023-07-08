using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Patients> patients = new List<Patients>();
        int option = 10;
        while (option != 0)
        {
            switch (option)
            {
                case 1:
                {
                    Patients p1 = new Patients();
                    p1.CreatePatients();
                    p1.DisplayInfo();
                    break;
                }
            }

            //Only the interface and classes were created, as well as their class methods, variables, and some constructors. But they are still subject to modification.//
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Add New Patient");
            Console.WriteLine("  2. Add a Membership to Patient");
            Console.WriteLine("  3. Add New Student");
            Console.WriteLine("  4. Add New Treatment");
            Console.WriteLine("  5. Add/Update Inventory");
            Console.WriteLine("  6. Create New Promotion");
            Console.WriteLine("  7. Save/Load File");
            Console.WriteLine("  0. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            option = int.Parse(userInput);
        }
    }
}