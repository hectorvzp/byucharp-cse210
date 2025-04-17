public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity (seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to start...");
        Spinner.ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("Well done! You've completed the activity.");
        Console.WriteLine($"You practiced {_name} for {_duration} seconds.");
        Spinner.ShowSpinner(3);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public abstract void Run();
}
