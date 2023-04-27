using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int sqr = SquareNumber(userNumber);
        DisplayResult(userName, sqr);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber(){
        Console.Write("What is your favorite number? ");
        string userNumber = Console.ReadLine();
        int userFav_Number = int.Parse(userNumber);
        return userFav_Number;
    }

    static int SquareNumber(int number){
        double square = Math.Pow(number,2);
        int sqr = Convert.ToInt32(square);
        return sqr;
    }

    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}