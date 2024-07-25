public class OutdoorGathering(string title, string description, string date, string time, Address address, string forecast) : Event(title, description, date, time, address)
{
    private readonly string _forecast = forecast;

    public override string GetFullDetails()
    {
        return ($"{base.GetStandardDetails()} Event Type: Outdoor Gathering forecast: {_forecast}");
    }
}