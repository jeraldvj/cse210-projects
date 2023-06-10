using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        while (option != 4)
        {
            switch (option)
            {
                case 1:
                {
                    BreathingActivity a1 = new BreathingActivity();
                    Console.Clear();
                    a1.StartingMessage();
                    a1.DisplayBreathing();
                    a1.EndingMessage();
                    break;
                }
                case 2:
                {
                    ReflectionActivity r1 = new ReflectionActivity();
                    Console.Clear();
                    r1.StartingMessage();
                    r1.DisplayReflection();
                    r1.EndingMessage();
                    break;
                }
                case 3:
                {
                    ListingActivity l1 = new ListingActivity();
                    Console.Clear();
                    l1.StartingMessage();
                    l1.DisplayListing();
                    l1.EndingMessage();
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            option = int.Parse(userInput);
        }
    }
}