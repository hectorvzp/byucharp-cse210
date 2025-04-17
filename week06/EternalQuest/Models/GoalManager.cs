using EternalQuest.Models;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void CreateGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Event recorded! You earned {pointsEarned} points.");
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void DisplayScore() => Console.WriteLine($"Current Score: {_score}");

    public void SaveGoals(string filename)
    {
        using StreamWriter writer = new(filename);
        writer.WriteLine(_score);
        foreach (var goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        var lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            switch (type)
            {
                case "SimpleGoal":
                    var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.TryParse(parts[4], out bool complete) && complete)
                        simpleGoal.RecordEvent(); // Marcando como completo
                    _goals.Add(simpleGoal);
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;

                case "ChecklistGoal":
                    var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                 int.Parse(parts[5]), int.Parse(parts[4]));
                    // Simular progresso com RecordEvent?
                    _goals.Add(goal);
                    break;
            }
        }
    }
}
