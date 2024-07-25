using System;

public class Address(string street, string city, string state, string country)
{
    private readonly string _street = street;
    private readonly string _city = city;
    private readonly string _state = state;
    private readonly string _country = country;

    public bool LocalUSA()
    {
        return _country.Equals("united states", StringComparison.CurrentCultureIgnoreCase);
    }

    public string GetFullAddress()
    {
        return ($"{_street}, {_city}, {_state}, {_country}");
    }
}