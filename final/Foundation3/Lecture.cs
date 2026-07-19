public class Lecture : Event
{
    private string _speakerName;
    private int _venueCapacity;

    public Lecture(string title, string description, string date, string time, EventAddress address, string speakerName, int venueCapacity) 
        : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _venueCapacity = venueCapacity;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {_speakerName}\nCapacity: {_venueCapacity} people";
    }
}