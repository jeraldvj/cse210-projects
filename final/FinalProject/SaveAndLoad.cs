using System;

public class SaveAndLoad{
    private List<Patients> _patients = new List<Patients>();
    private List<Students> _students = new List<Students>();
    private List<Inventory> _inventories = new List<Inventory>();
    private int _lastPatientID;
    private int _lastStudentID;
    private int _lastInventoryID;

    public void SavePatientsToFile(string fileName, int lastID, List<Patients> listOfPatients){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{lastID}");
            foreach(Patients patient in listOfPatients){       
                outputFile.WriteLine(patient.SaveToFile());
            }
        }
    }

    public void SaveStudentsToFile(string fileName, int lastID, List<Students> listOfStudents){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{lastID}");
            foreach(Students student in listOfStudents){       
                outputFile.WriteLine(student.SaveToFile());
            }
        }
    }

    public void SaveInventoriesToFile(string fileName, int lastID, List<Inventory> listOfInventories){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{lastID}");
            foreach(Inventory inventory in listOfInventories){       
                outputFile.WriteLine(inventory.SaveToFile());
            }
        }
    }

    public List<Patients> LoadPatientsFromFile(){
        
        string[] lines = System.IO.File.ReadAllLines("patients.txt");
        int first = 0;
        foreach (string line in lines)
        {
            char[] separator = {':',','};
            string[] parts = line.Split(separator);
            if (first == 0)
            {
                _lastPatientID = int.Parse(parts[0]);
                first = 1;
            }
            else
            {
                Patients pl1 = new Patients(int.Parse(parts[0]),parts[1],parts[2],int.Parse(parts[3]),DateTime.Parse(parts[4]),parts[5],parts[6]);
                _patients.Add(pl1);
            }

        }
        return _patients;
    }

    public List<Students> LoadStudentsFromFile(){
        
        string[] lines = System.IO.File.ReadAllLines("students.txt");
        int first = 0;
        foreach (string line in lines)
        {
            char[] separator = {':',','};
            string[] parts = line.Split(separator);
            if (first == 0)
            {
                _lastStudentID = int.Parse(parts[0]);
                first = 1;
            }
            else
            {
                Students sl1 = new Students(int.Parse(parts[0]),DateTime.Parse(parts[1]),parts[2],parts[3],DateTime.Parse(parts[4]),parts[5]);
                _students.Add(sl1);
            }

        }
        return _students;
    }

    public List<Inventory> LoadInventoriesFromFile(){
        
        string[] lines = System.IO.File.ReadAllLines("inventories.txt");
        int first = 0;
        foreach (string line in lines)
        {
            char[] separator = {':',','};
            string[] parts = line.Split(separator);
            if (first == 0)
            {
                _lastInventoryID = int.Parse(parts[0]);
                first = 1;
            }
            else
            {
                Inventory il1 = new Inventory(int.Parse(parts[0]),parts[1],int.Parse(parts[2]),parts[3]);
                _inventories.Add(il1);
            }

        }
        return _inventories;
    }

    public int GetLastPatientID(){
        return _lastPatientID;
    }

    public int GetLastStudentID(){
        return _lastStudentID;
    }

    public int GetLastInventoryID(){
        return _lastInventoryID;
    }

}