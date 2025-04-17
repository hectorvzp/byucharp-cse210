public class ListingActivity : Activity
{
    private List<string> _prompts = new() {
        "Who are the people you appreciate?",
        "What are your personal strengths?"
    };

    public ListingActivity() : base("Listing activity", "List as many positive things as possible.") { }

    public override void Run()
    {
        Start();
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Count)]);
        Spinner.ShowCountdown(3);

        Console.WriteLine("Type in your answers (press ENTER after each one):");

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You've listed {count} items!");
        End();
    }
}
