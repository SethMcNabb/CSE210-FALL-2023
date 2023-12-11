class ListingActivity : Activity
{
    private List<string> _items;
    private List<string> _topics;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _items = new List<string>();
        _topics = new List<string> { "people you appreciate", "personal strengths", "good deeds", "moments you felt joy" };
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Randomly select a topic
        string randomTopic = GetRandomTopic();
        Console.WriteLine($"List as many things as you can related to: {randomTopic}");
        Console.WriteLine("Start listing...");

        // Use the entire duration for the single prompt
        Console.Write("Enter an item: ");
        _items.Add(Console.ReadLine());

        Console.WriteLine($"Listing completed! You entered {_items.Count} item(s).");
        DisplayEndingMessage();
    }

    private string GetRandomTopic()
    {
        Random random = new Random();
        int index = random.Next(_topics.Count);
        return _topics[index];
    }
}
