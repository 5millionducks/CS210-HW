public class Running(string date, int length, double distance) : Activity(date, length)
{
    private readonly double _distance = distance;

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance) / (Length);
    }

    public override double GetPace()
    {
        return Length / (_distance);
    }
}