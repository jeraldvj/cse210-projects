using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string option = "enter";
        
        Scripture s1 = new Scripture();
        s1._reference.SetBook("Proverbs");
        s1._reference.SetChapter(3);
        s1._reference.SetInitialVerse(5);
        s1._reference.SetFinalVerse(6);

        string scripture = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        string[] parts = scripture.Split(" ");
        int countWords = parts.Count();
        
        for (int i = 0; i < countWords; i++)
            {
                
                Word w1 = new Word();  
                w1.SetWordContent(parts[i]);

                s1._word.Add(w1);
            }

        s1.DisplayScripture();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        option = Console.ReadLine();
        // This will clear the console
        Console.Clear();

        while (option != "quit")
        {
        
            int randomcount = 0;
            while (randomcount != 3)
            {
            foreach (var word in s1._word)
                {
                    if (word.GetStatus() == true)
                    {
                        Random randomGenerator = new Random();
                        int randomOption = randomGenerator.Next(0, 2);
                        if (randomOption == 1)
                        {
                            string wordHidden = word.GetContent();
                            word.SetWordContent(wordHidden);
                            word.SetStatus(false);
                            randomcount += 1;
                            if (randomcount == 3)
                            {
                                break;
                            }
                        }  
                    }
                } 
                
            }
            s1.DisplayScripture();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            option = Console.ReadLine();
            // This will clear the console
            Console.Clear();

            int finalCount = 0;
            foreach (var word in s1._word)
                {
                    if (word.GetStatus() == false)
                    {
                        finalCount += 1;
                    }
                    if (finalCount == countWords)
                    {
                        option = "quit";
                    }
                }
            
        }
    }
}