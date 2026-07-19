using System;

public class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual float GetDistance()
    {
        return 0.0f;
    }

    public virtual float GetSpeed()
    {
        return 0.0f;
    }

    public virtual float GetPace()
    {
        return 0.0f;
    }

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthInMinutes} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}