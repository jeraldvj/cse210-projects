using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Patients> patients = new List<Patients>();
        List<Students> students = new List<Students>();
        List<Inventory> inventories = new List<Inventory>();
        int lastPatientID = 0;
        int lastStudentID = 0;
        int lastInventoryID = 0;
        int categoryOption = 5;
        //string userIn = " ";
        while (categoryOption != 0)
        {
            switch (categoryOption)
            {
                case 1: //Patient Options
                {
                    Console.WriteLine("Patient Options:");
                    Console.WriteLine("  1. Add New Patient");
                    Console.WriteLine("  2. Show All Patients");
                    Console.WriteLine("  3. Search Patient by ID");
                    Console.WriteLine("  4. Add Treatment to Patient");
                    Console.WriteLine("  5. Add a Membership Patient");
                    Console.Write("Select a choice from the menu: ");
                    string userIn = Console.ReadLine();
                    int patientOption = int.Parse(userIn);
                    switch (patientOption)
                    {
                        
                        case 1:
                        {
                            Patients p1 = new Patients();
                            p1.CreatePatients(lastPatientID);
                            Console.WriteLine();
                            patients.Add(p1);
                            lastPatientID = p1.GetPatientID();
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Patient Info:");
                            foreach (Patients patient in patients)
                            {
                                patient.DisplayShortInfo();
                            }
                            Console.WriteLine();
                            break;
                        }
                        case 3:
                        {
                            Console.Write("Search Patient ID:");
                            string user = Console.ReadLine();
                            int userChoice = int.Parse(user);
                            foreach (Patients patient in patients)
                            {
                                if (patient.GetPatientID() == userChoice)
                                {
                                    patient.DisplayInfo();
                                }
                            }
                            break;
                        }
                        case 4:
                        {
                            Console.Write("Search Patient ID:");
                            string user = Console.ReadLine();
                            int userChoice = int.Parse(user);
                            foreach (Patients patient in patients)
                            {
                                if (patient.GetPatientID() == userChoice)
                                {
                                    Treatments t1 = new Treatments();
                                    patient.AddTreatmentToPatient(t1);
                                }
                            }
                            break;
                        }
                        case 5:
                        {
                            Console.WriteLine();
                            Console.WriteLine("  1. VIP Patient");
                            Console.WriteLine("  2. Gold Patient");
                            Console.Write("  Type your choice: ");
                            string user = Console.ReadLine();
                            int userChoice = int.Parse(user);
                            switch (userChoice)
                            {
                                case 1:
                                {
                                    PatientsVIP pv1 = new PatientsVIP();
                                    pv1.CreatePatients(lastPatientID);
                                    Console.WriteLine();
                                    patients.Add(pv1);
                                    lastPatientID = pv1.GetPatientID();
                                    break;
                                }
                                case 2:
                                {
                                    PatientsGold pg1 = new PatientsGold();
                                    pg1.CreatePatients(lastPatientID);
                                    pg1.CreateMembership();
                                    Console.WriteLine();
                                    patients.Add(pg1);
                                    lastPatientID = pg1.GetPatientID();
                                    break;
                                }
                                default:
                                {
                                    Console.WriteLine("  --Unvalid entry--");
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
                case 2: //Student Options
                {
                    Console.WriteLine("Student Options:");
                    Console.WriteLine("  1. Add New Student");
                    Console.WriteLine("  2. Show All Students");
                    Console.WriteLine("  3. Search Student by ID");
                    Console.WriteLine("  4. Add Course/Certification to Student");
                    Console.Write("Select a choice from the menu: ");
                    string userIn = Console.ReadLine();
                    int studentOption = int.Parse(userIn);

                    switch (studentOption)
                    {
                        case 1:
                        {
                            Students s1 = new Students();
                            s1.CreateStudents(lastStudentID);
                            Console.WriteLine();
                            students.Add(s1);
                            lastStudentID = s1.GetStudentID();
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Student Info:");
                            foreach (Students student in students)
                            {
                                student.DisplayShortInfo();
                            }
                            Console.WriteLine();
                            break;
                        }
                        case 3:
                        {
                            Console.WriteLine();
                            Console.Write("Search Student ID: ");
                            string user = Console.ReadLine();
                            int userChoice = int.Parse(user);
                            foreach (Students student in students)
                            {
                                if (student.GetStudentID() == userChoice)
                                {
                                    student.DisplayInfo();
                                }
                            }
                            break;
                        }
                        case 4:
                        {
                            Console.WriteLine();
                            Console.Write("Search Student ID: ");
                            string user = Console.ReadLine();
                            int userChoice = int.Parse(user);
                            foreach (Students student in students)
                            {
                                if (student.GetStudentID() == userChoice)
                                {
                                    Console.WriteLine("  1. Add Course");
                                    Console.WriteLine("  2. Add Certificate");
                                    Console.Write("  Type your choice: ");
                                    string userOption = Console.ReadLine();
                                    int shortOption = int.Parse(userOption);
                                    switch (shortOption)
                                    {
                                        case 1:
                                        {
                                            Courses co1 = new Courses();
                                            student.AddCourse(co1);
                                            break;
                                        }
                                        case 2:
                                        {
                                            Certificates ce1 = new Certificates();
                                            student.AddCertificate(ce1);
                                            break;
                                        }
                                        default:
                                        {
                                            Console.WriteLine("  --Unvalid entry--");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("  --Student ID not found--");
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
                case 3: //Other Options
                {
                    Console.WriteLine("Other Options:");
                    Console.WriteLine("  1. Add Inventory");
                    Console.WriteLine("  2. Show Inventory");
                    Console.WriteLine("  3. Update Inventory");
                    Console.WriteLine("  4. Save Files");
                    Console.WriteLine("  5. Load Files");
                    Console.Write("Select a choice from the menu: ");
                    string userIn = Console.ReadLine();
                    int otherOption = int.Parse(userIn);
                    switch (otherOption)
                    {
                        case 1: // Add Inventory
                        {
                            Console.WriteLine();
                            Console.WriteLine("  1. Product without expiration");
                            Console.WriteLine("  2. Product with expiration");
                            Console.Write("What inventory do you want to add? ");
                            string user = Console.ReadLine();
                            int choose = int.Parse(user);
                                if (choose == 1)
                                {
                                    Inventory i1 = new Inventory(lastInventoryID);
                                    inventories.Add(i1);
                                }
                                else if (choose == 2)
                                {
                                    ProductInventory pi1 = new ProductInventory(lastInventoryID);
                                    inventories.Add(pi1);
                                }
                            break;
                        }
                        case 2: // Show Inventory
                        {
                            foreach (Inventory inventory in inventories)
                            {
                                inventory.DisplayInfo();
                            }
                            Console.WriteLine();
                            break;
                        }
                        case 3: // Update Inventory
                        {
                            foreach (Inventory inventory in inventories)
                            {
                                inventory.DisplayInfo();
                            }
                            Console.WriteLine();
                            Console.Write("Product ID to Update: ");
                            string user = Console.ReadLine();
                            int id = int.Parse(user);
                            
                            foreach (Inventory inventory in inventories)
                            {
                                if (inventory.GetInventoryID() == id)
                                {
                                    inventory.DisplayInfo();
                                    Console.Write("Amount to Update: ");
                                    user = Console.ReadLine();
                                    int newAmount = int.Parse(user);
                                    inventory.SetAmount(newAmount);
                                }
                                else
                                {
                                    Console.WriteLine("  --Inventory ID not found--");
                                }
                            }
                            break;
                        }
                        case 4: // Save Files
                        {
                            SaveAndLoad file = new SaveAndLoad();
                            file.SavePatientsToFile("patients.txt", lastPatientID, patients);

                            file.SaveStudentsToFile("students.txt", lastStudentID, students);

                            file.SaveInventoriesToFile("inventories.txt", lastInventoryID, inventories);
                            Console.WriteLine("  --Files Saved successfully!--");
                            break;
                        }
                        case 5: // Load Files
                        {
                            SaveAndLoad file = new SaveAndLoad();
                            patients.Clear();
                            foreach (Patients patient in file.LoadPatientsFromFile())
                            {
                                patients.Add(patient);
                            }
                            lastPatientID = file.GetLastPatientID();

                            students.Clear();
                            foreach (Students student in file.LoadStudentsFromFile())
                            {
                                students.Add(student);
                            }
                            lastStudentID = file.GetLastStudentID();

                            inventories.Clear();
                            foreach (Inventory inventory in file.LoadInventoriesFromFile())
                            {
                                inventories.Add(inventory);
                            }
                            lastInventoryID = file.GetLastInventoryID();
                            
                            break;
                        }
                    }
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Patient Options");
            Console.WriteLine("  2. Student Options");
            Console.WriteLine("  3. Other Options");
            Console.WriteLine("  0. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            categoryOption = int.Parse(userInput);
            Console.WriteLine();
        }
    }
}