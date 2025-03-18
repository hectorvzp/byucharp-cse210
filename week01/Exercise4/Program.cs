using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        string numero = "1";
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int sum = 0;
        int count = 0;
        int larger = 0;
        int smallerPositive = 100;
        while (numero != "0")
        {
            Console.Write(" Enter number:");
            numero = Console.ReadLine();
            int number = int.Parse(numero);
            sum += number;
            count += 1;

            if (number > larger)
            {
                larger = number;
            }
            if (number > 0 && number < smallerPositive)
            {
                smallerPositive = number;
            }

            numbers.Add(number);
        }
        numbers.Sort();
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The Average is: {sum / count}");
        Console.WriteLine($"The Largest number  is: {larger}");
        Console.WriteLine($"The smallest positive number  is: {smallerPositive}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int iten in numbers)
        {
            Console.WriteLine(iten);
        }



    }
}