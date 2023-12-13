class Receptions : Event
{
    private int countRsvp;

    public Receptions(string title, string description, string date, string time, int countRsvp, Address address)
        : base(title, description, date, time, address)
    {
        this.countRsvp = countRsvp;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Reception\nRSVP Count: {countRsvp}";
    }

    public override string ShortDescription()
    {
        return $"Event Type: Reception, Title: {title}, Date: {date}";
    }
}