using System;


public class Customer(string name, Address address)
{
    private readonly string _name = name;
    private readonly Address _address = address;

    public bool LocalUSA()
    {
        return _address.LocalUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}