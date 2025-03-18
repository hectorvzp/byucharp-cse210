using System;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks.Dataflow;

class Program

{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);
            int intGuess = 0;
            while (intGuess != magicNumber)
            {
                Console.Write(" What is the magic number? ");
                string guess = Console.ReadLine();
                intGuess = int.Parse(guess);
                if (intGuess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.Write("Do you want to continue? ");
                    response = Console.ReadLine().ToLower();
                }

                else if (intGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            }
        }





    }
}