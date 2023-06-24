using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        int totalPoints = 0;
        string fileName;

        List<Goal> goals = new List<Goal>();
        while (option != 6)
        {
            switch (option)
            {
                case 1:
                {
                    Console.WriteLine();
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string user_Input = Console.ReadLine();
                    int createOption = int.Parse(user_Input);

                    switch (createOption)
                    {
                        case 1:
                        {
                            SimpleGoal sg = new SimpleGoal();
                            sg.CreateSimpleGoal();
                            goals.Add(sg);
                            break;
                        }
                        case 2:
                        {
                            EternalGoal eg = new EternalGoal();
                            eg.CreateEternalGoal();
                            goals.Add(eg);
                            break;
                        }
                        case 3:
                        {
                            CheckListGoal clg = new CheckListGoal();
                            clg.CreateCheckListGoal();
                            goals.Add(clg);
                            break;
                        }
                    }
                    break;
                }
                case 2:
                {
                    int cont = 1;
                    Console.WriteLine();
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine($"{cont}{goal.DisplayListGoals()}");
                        cont++;
                    }
                    break;
                }
                case 3:
                {
                    File file = new File();
                    Console.Write("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();
                    file.SaveToFile(fileName, totalPoints, goals);
                    break;
                }

                case 4:
                {
                    File file = new File();
                    Console.Write("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();
                    goals.Clear();
                    foreach (Goal goal in file.LoadFromFile(fileName))
                    {
                        goals.Add(goal);
                    }
                    totalPoints = file.NewData();
                    break;
                }

                case 5:
                {
                    int cont = 1;
                    Console.WriteLine();
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine($"{cont}. {goal.GetName()}");
                        cont++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    string user_Input = Console.ReadLine();
                    int userChoice = int.Parse(user_Input);
                    cont = 1;
                    foreach (Goal goal in goals)
                    {
                        if (userChoice == cont)
                        {
                            Console.WriteLine();
                            totalPoints += goal.RecordEvent();
                            Console.WriteLine($"Now have {totalPoints} points.");
                        }
                        cont++;
                    }
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Events");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            option = int.Parse(userInput);
        }
    }
}