public class ChecklistGoal(string name, string description, int points, int goalTarget, int bonusPoints) : Goal(name, description, points)
{
    public int GoalTarget { get; private set; } = goalTarget;
    public int CurrentCount { get; private set; } = 0;
    public int BonusPoints { get; private set; } = bonusPoints;

    public override void RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= GoalTarget)
        {
            IsCompleted = true;
        }
    }
}