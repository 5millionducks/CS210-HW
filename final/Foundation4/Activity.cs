public abstract class Activity(string date, int length)
{
    protected DateTime _date = DateTime.Parse(date);
    protected int _length = length;

    public string Date => FormatDate(_date);

    public int Length => _length;

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return ($"{Date} {GetType().Name} ({Length} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }

    private static string FormatDate(DateTime date)
    {
        string month = date.ToString("MMM");
        month = char.ToUpper(month[0]) + month.Substring(1);
        return $"{month} {date:dd} {date:yyyy}";
    }
}