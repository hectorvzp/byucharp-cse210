using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string aproveed;
        string mais;
        Console.Write("What's your grade?");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80 && gradeNumber < 90)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70 && gradeNumber < 80)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60 && gradeNumber < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        int ultimoDigito = gradeNumber % 10;

        if (ultimoDigito >= 7)
        {
            mais = "+";

        }
        else if (ultimoDigito <= 3)
        {
            mais = "-";
        }
        else
        {
            mais = "";
        }
        if (letter == "A" || letter == "B" || letter == "C")
        {
            aproveed = "Congratulations you did very well";
        }
        else
        {
            aproveed = "Unfortunately you didn't pass, you needs to improve";
        }

        if (letter == "A")
        {

            Console.WriteLine($"Your grade was: {letter}, {aproveed}");
        }
        else if (letter == "B" || letter == "C")
        {
            Console.WriteLine($"Your grade was: {letter}{mais}, {aproveed}");
        }
        else
        {
            Console.WriteLine($"Your grade was: {letter}{mais}, {aproveed}");

        }
    }
}