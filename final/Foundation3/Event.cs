public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private EventAddress _address;

    public Event(string title, string description, string date, string time, EventAddress address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date} at {_time}\nLocation: {_address.GetFormattedAddress()}";
    }

    public string GetShortDescription(string eventType)
    {
        return $"Event Type: {eventType}\nTitle: {_title}\nDate: {_date}";
    }
}