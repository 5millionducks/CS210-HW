public class Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : Event(title, description, date, time, address)
{
    private readonly string _speaker = speaker;
    private readonly int _capacity = capacity;

    public override string GetFullDetails()
    {
        return ($"{base.GetStandardDetails()} Event Type: Lecture Speaker: {_speaker} Capacity: {_capacity} guests");
    }
}