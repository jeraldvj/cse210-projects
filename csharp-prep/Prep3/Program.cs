using System;

class Program
{
    static void Main(string[] args)
    {   
        string option = "yes";
        do{
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = 0;
        int counter = 0;

        while (magicNumber != userGuess){
            Console.Write("What is your guess? ");
            string user_Input = Console.ReadLine();
            userGuess = int.Parse(user_Input);

            if (userGuess < magicNumber){
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber){
                Console.WriteLine("Lower");
            }
            counter += 1;
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"You found the magic number in {counter} tries");
        Console.Write("Do you want to play the game again? (yes/no): ");
        option = Console.ReadLine();
        } while (option == "yes");
    }
}