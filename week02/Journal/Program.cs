using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        Entry _entry = new Entry();
        string decision = "yes";
        while (decision == "yes")
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            try
            {
                int _answer = int.Parse(answer);

                if (_answer < 1 || _answer > 5)
                {
                    Console.WriteLine(" Only numbers between 1 and 5 are valid");

                }

                else if (answer == "5")
                {
                    Console.WriteLine("Thank You!!");
                    decision = "no";

                }
                else if (answer == "1")
                {
                    _entry.Display(_journal);
                }
                else if (answer == "2")
                {
                    _journal.DisplayAlla();
                }
                else if (answer == "3")
                {
                    _journal.LoadFromFile();
                }
                else if (_answer == 4)
                {
                    _journal.SaveToFile();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Just Numbers " + ex.Message);

            }
        }
    }
}

