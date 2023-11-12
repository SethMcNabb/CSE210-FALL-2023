public class Entry
{
    public string date;
    public string prompt;
    public string entry;

    public Entry(string _date, string _prompt, string _entry)
    {
        date = _date;
        prompt = _prompt;
        entry = _entry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {date} - {prompt}");
        Console.WriteLine(entry);
    }
}