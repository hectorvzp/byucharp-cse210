using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("1. Respiratory activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string option = Console.ReadLine();
            Activity activity = option switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectingActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (activity == null)
            {
                if (option == "4") break;
                Console.WriteLine("Invalid option.");
                Thread.Sleep(2000);
            }
            else
            {
                activity.Run();
            }
        }
    }
}
