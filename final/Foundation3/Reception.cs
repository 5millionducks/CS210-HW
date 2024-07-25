public class Reception(string title, string description, string date, string time, Address address, string rsvp) : Event(title, description, date, time, address)
{
    private readonly string _rsvp = rsvp;

    public override string GetFullDetails()
    {
        return ($"{base.GetStandardDetails()} Event Type: Reception RSVP Email: {_rsvp}");
    }
}