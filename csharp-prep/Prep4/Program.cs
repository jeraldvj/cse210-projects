using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int d_number = 1;
        float sum = 0;
        int max = 0;
        int small = 1000;
        int counter = 0;
        List<int> numbers = new List<int>();
        while (d_number !=0){
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            d_number = int.Parse(userInput);
            
            sum += d_number;
            if (max < d_number){
                max = d_number;
            }
            if(d_number > 0 && d_number < small){
                small = d_number;
            }

            if (d_number != 0){
                ++counter;
                numbers.Add(d_number);
            }
        }
        float aver = sum/counter;
        numbers.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {aver}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {small}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}