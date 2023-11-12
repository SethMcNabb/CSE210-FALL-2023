public class PromptGenerator
{
    List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "How did you see the Lord's influcece in your life today?",
            "What is one thing you wish you could have done better at?",
            "Did you help anyone today? If not how can you tomorrow?",
            "What is something you forgot to do today that you can do tomorrow?",
            "What are three things you are grateful for in this moment?"
        };
    }

    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex = new Random().Next(prompts.Count);
        randomPrompt = prompts[randomIndex];
        return randomPrompt;
    }

}