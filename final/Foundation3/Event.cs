public class Event(string title, string description, string date, string time, Address address)
{
    private readonly string _title = title;
    private readonly string _description = description;
    private readonly string _date = date;
    private readonly string _time = time;
    private readonly Address _address = address;

    public virtual string GetStandardDetails()
    {
        return ($"Event Name: {_title} Description: {_description} Date: {_date} Time: {_time} Address: {_address.GetAddress()}");
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return ($"Event Type: {this.GetType().Name} Event Name: {_title} Date: {_date}");
    }
}