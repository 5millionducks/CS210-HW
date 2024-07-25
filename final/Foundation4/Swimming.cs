public class Swimming(string date, int length, int laps) : Activity(date, length)
{
    private readonly int _laps = laps;

    public override double GetDistance()
    {
        return (_laps * 50 / 1000.0) * 0.621371; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / (Length);
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }
}