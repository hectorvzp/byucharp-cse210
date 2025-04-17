using System;
using EternalQuest.Models;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Choose goal type: 1) Simple 2) Eternal 3) Checklist");
                    string type = Console.ReadLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    switch (type)
                    {
                        case "1":
                            manager.CreateGoal(new SimpleGoal(name, desc, points));
                            break;
                        case "2":
                            manager.CreateGoal(new EternalGoal(name, desc, points));
                            break;
                        case "3":
                            Console.Write("Target count: ");
                            int target = int.Parse(Console.ReadLine());
                            Console.Write("Bonus: ");
                            int bonus = int.Parse(Console.ReadLine());
                            manager.CreateGoal(new ChecklistGoal(name, desc, points, target, bonus));
                            break;
                    }
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    manager.DisplayGoals();
                    Console.Write("Enter goal number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;

                case "4":
                    manager.DisplayScore();
                    break;

                case "5":
                    manager.SaveGoals("goals.txt");
                    break;

                case "6":
                    manager.LoadGoals("goals.txt");
                    break;

                case "7":
                    running = false;
                    break;
            }
        }
    }
}