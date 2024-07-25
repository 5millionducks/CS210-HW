public class Address(string street, string city, string state, string zip)
{
    private readonly string _street = street;
    private readonly string _city = city;
    private readonly string _state = state;
    private readonly string _zip = zip;

    public string GetAddress()
    {
        return ($"{_street}, {_city}, {_state} - {_zip}");
    }
}