class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int interval = _duration / 6;
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(interval);
            Console.Write("Breathe out...");
            ShowCountDown(interval);
        }
        DisplayEndingMessage();
    }
}