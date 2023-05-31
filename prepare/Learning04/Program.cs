using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment mathAssign1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssign1.GetSummary());
        Console.WriteLine(mathAssign1.GetHomeworkList());

        WritingAssignment writingAssign1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssign1.GetSummary());
        Console.WriteLine(writingAssign1.GetWritingInformation());

        

    }
}