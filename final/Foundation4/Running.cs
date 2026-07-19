public class Running : Activity
{
    private float _distanceInMiles;

    public Running(string date, int lengthInMinutes, float distanceInMiles) 
        : base(date, lengthInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }

    public override float GetDistance()
    {
        return _distanceInMiles;
    }

    public override float GetSpeed()
    {
        return (_distanceInMiles / GetLengthInMinutes()) * 60.0f;
    }

    public override float GetPace()
    {
        return GetLengthInMinutes() / _distanceInMiles;
    }
}