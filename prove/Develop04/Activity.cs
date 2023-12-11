class Activity
{
    public string _name,_description;
    public int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        _duration = GetDuration();
        Console.WriteLine($"You will have {_duration} seconds for this activity.");
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You've spent {_duration} seconds on {_name}.");
        Thread.Sleep(3000);
    }

    public void ShowSpinner()
    {
        Console.Write("Loading");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        Console.WriteLine();
    }
    
    public void ShowCountDown(int interval)
    {
        for (int i = interval; i >= 1; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
        public int GetDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        return int.Parse(Console.ReadLine());
    }
}