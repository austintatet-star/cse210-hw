public class Cycling : Activity
{
    private float _speedInMph;

    public Cycling(string date, int lengthInMinutes, float speedInMph) 
        : base(date, lengthInMinutes)
    {
        _speedInMph = speedInMph;
    }

    public override float GetDistance()
    {
        return (_speedInMph * GetLengthInMinutes()) * 60.0f;
    }

    public override float GetSpeed()
    {
        return _speedInMph;
    }

    public override float GetPace()
    {
        return 60.0f / _speedInMph;
    }
}