public class EternalGoal(string name, string description, int points) : Goal(name, description, points)
{
    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
        }
    }
}