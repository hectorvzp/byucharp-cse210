public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Atividade Respiratória", "Ajuda a relaxar com respiração profunda.") {}

    public override void Run()
    {
        Start();
        int seconds = GetDuration();
        int cycle = seconds / 6; // 3s inalar + 3s exalar

        for (int i = 0; i < cycle; i++)
        {
            Console.Write("Inspire...");
            Spinner.ShowCountdown(3);
            Console.Write("Expire...");
            Spinner.ShowCountdown(3);
        }

        End();
    }
}
