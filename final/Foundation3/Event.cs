class Event
{
    protected string title;
    protected string description;
    protected string date;  // Change from private to protected
    private string time;
    private Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string StandardDetails()
    {
        return $"{title}\n{description}\n{date} at {time}\nLocation: {address.GetAddressString()}";
    }

    public virtual string FullDetails()
    {
        return $"{StandardDetails()}";
    }

    public virtual string ShortDescription()
    {
        return $"Event Type: Generic, Title: {title}, Date: {date}";
    }
}