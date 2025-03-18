using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static string DisplayWelcome()
        {
            string welcomee = "Welcome to the program!";
            Console.WriteLine(welcomee);
            return welcomee;
        }
        static int UserNumber()
        {
            Console.Write("What is your  favorite number? ");
            string number = Console.ReadLine();
            int numberInt = int.Parse(number);
            return numberInt;
        }
        static string PromptUserName()
        {
            Console.Write("What is your  name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int SquareNumber(int number)
        {
            number *= number;
            return number;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {number}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = UserNumber();
        int sq = SquareNumber(number);
        DisplayResult(name, sq);

    }
}