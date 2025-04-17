namespace EternalQuest.Models
{
    public class ChecklistGoal : Goal
    {
        private int _timesCompleted;
        private int _targetCount;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _bonus = bonus;
            _timesCompleted = 0;
        }

        public override int RecordEvent()
        {
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
                return Points + _bonus;
            else
                return Points;
        }

        public override bool IsComplete() => _timesCompleted >= _targetCount;

        public override string GetDetailsString()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {Name} ({Description}) -- Completed {_timesCompleted}/{_targetCount}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{Name}|{Description}|{Points}|{_bonus}|{_targetCount}|{_timesCompleted}";
        }
    }
}
