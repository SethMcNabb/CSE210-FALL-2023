class OutdoorGatherings : Event
{
    private string weather;

    public OutdoorGatherings(string title, string description, string date, string time, string weather, Address address)
        : base(title, description, date, time, address)
    {
        this.weather = weather;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
    }

    public override string ShortDescription()
    {
        return $"Event Type: Outdoor Gathering, Title: {title}, Date: {date}";
    }
}