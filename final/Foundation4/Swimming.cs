public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int lengthInMinutes, int numberOfLaps) 
        : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float GetDistance()
    {
        return (_numberOfLaps * 50.0f) / 1000.0f * 0.62f;
    }

    public override float GetSpeed()
    {
        return (GetDistance() / GetLengthInMinutes()) * 60.0f;
    }

    public override float GetPace()
    {
        return GetLengthInMinutes() / GetDistance();
    }
}