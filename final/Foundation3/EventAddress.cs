public class EventAddress
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public EventAddress(string street, string city, string state, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public string GetFormattedAddress()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}";
    }
}