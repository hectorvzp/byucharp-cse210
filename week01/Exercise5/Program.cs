using System;

class Program
{
    static void Main(string[] args)
    {
        static string DisplayWelcome()
        {
            string welcomee = ("Welcome to the program!");
            console.WriteLine(welcomee);
            return welcomee;
        }
        static int PromptUserNumber()
        {
            console.Write("What is your  favorite number?");
            string number = console.ReadLine();
            int numberInt = int.parse(number)
            return numberInt;
        }
        static string PromptUserName()
        {
            console.Write("What is your  name?");
            string name = console.ReadLine();
            return name;
        }
        static int SquareNumber(int number)
        {
            int number = number * number
            return number;
        }
        static void DisplayResult(string name, int number)
        {
            console.WriteLine($"Brother {name}, the square of your number is {number}")
        }

    DisplayWelcome()
    }
}