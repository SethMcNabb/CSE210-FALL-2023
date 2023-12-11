using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        List<string> menu = new List<string>
        {
            "Menu Options:",
            "1 - Start breathing activity",
            "2 - Start reflecting activity",
            "3 - Start listing activity",
            "4 - Quit",
        };

        while (userChoice != 4)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu:");
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
            }

        }
    }
}