public class Activity
{
    // TODO: Add private attributes for date (string) and length in minutes (int)

    public Activity()
    {
        // TODO: Add constructor parameters to initialize variables
    }

    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        return 0;
    }

    public virtual float GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        // TODO: Use GetDistance(), GetSpeed(), and GetPace() to format the overview string
        return "";
    }
}