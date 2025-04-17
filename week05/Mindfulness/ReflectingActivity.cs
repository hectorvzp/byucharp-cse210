public class ReflectingActivity : Activity
{
    private List<string> _prompts = new() {
        "Think of a time when you defended someone else.",
        "Think of a time when you did something really difficult."
    };

    private List<string> _questions = new() {
        "Why was this experience significant for you?",
 "How did you get started?",
 "What did you learn about yourself?"
    };

    public ReflectingActivity() : base("Reflection Activity", "Reflect on your strength and resilience.") { }

    public override void Run()
    {
        Start();
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Count)]);
        Spinner.ShowSpinner(3);

        int endTime = Environment.TickCount + (GetDuration() * 1000);
        while (Environment.TickCount < endTime)
        {
            Console.WriteLine(_questions[rnd.Next(_questions.Count)]);
            Spinner.ShowSpinner(5);
        }

        End();
    }
}
