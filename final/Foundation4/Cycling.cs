public class Cycling(string date, int length, double speed) : Activity(date, length)
{
    private readonly double _speed = speed;

    public override double GetDistance()
    {
        return (_speed) * (Length);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }
}