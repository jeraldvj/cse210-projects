using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void DisplayBreathing(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int first = 0;
        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            if (first == 0){
                Console.Write("Breathe in...");
                WaitTime(2);
                Console.WriteLine();

                Console.Write("Now breathe out...");
                WaitTime(3);
                Console.WriteLine("\n");
                first = 1;
            }
            Console.Write("Breathe in...");
            WaitTime(4);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            WaitTime(6);
            Console.WriteLine("\n");
        }
    }  
}