public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, EventAddress address, string weatherForecast) 
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}