using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 4, 1), 30, 5.0),
            new Cycling(new DateTime(2024, 4, 2), 45, 20.0),
            new Swimming(new DateTime(2024, 4, 3), 40, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
