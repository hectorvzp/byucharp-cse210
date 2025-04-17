namespace EternalQuest.Models
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false;
        }

        public override int RecordEvent()
        {
            _isComplete = true;
            return Points;
        }

        public override bool IsComplete() => _isComplete;

        public override string GetDetailsString()
        {
            return $"[{(_isComplete ? "X" : " ")}] {Name} ({Description})";
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
        }
    }
}
