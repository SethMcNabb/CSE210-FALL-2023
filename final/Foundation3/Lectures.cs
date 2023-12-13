class Lectures : Event
{
    private string speaker;
    private int capacity;

    public Lectures(string title, string description, string date, string time, string speaker, int capacity, Address address)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }

    public override string ShortDescription()
    {
        return $"Event Type: Lecture, Title: {title}, Date: {date}";
    }
}