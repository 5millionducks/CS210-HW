public abstract class Goal(string name, string description, int points)
{
    public string Name { get; protected set; } = name;
    public string Description { get; protected set; } = description;
    public int Points { get; protected set; } = points;
    public bool IsCompleted { get; protected set; } = false;

    public abstract void RecordEvent();
}
