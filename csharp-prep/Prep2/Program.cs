using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter;
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 )
        {
            letter = "B";
        }
        else if (percentage >= 70 )
        {
            letter = "C";
        }
        else if (percentage >= 60 )
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // This part of the code assigns a sign after the degree letter, as long as it is not F or a + is not assigned if it is A.
        int mod = percentage % 10;
        string sign = "";
        if (mod >= 7 && letter != "A")
        {
            if (letter != "F")
            {
                sign = "+";
            }
        }
        else if (mod < 3 && letter != "F")
        {
            sign = "-";
        }

        Console.Write($"\nYour grade letter is {letter}{sign}");

        // This condition allows displaying the message according to its grade percentage.
        if (percentage >= 70)
        {
            Console.WriteLine($"\nCongratulation for your grade.");
        }
        else
        {
            Console.WriteLine($"\nYou can do better next semester, don't be discouraged.");
        }
    }
}