/*
int pointCount = 0;
simple goal (one time)
eternal goal (repeating infinite)
checklist goal (repeating set)

display the userScore
allow the user to create new goals of any type 
allow the user to report completed goals for points 
show a list of the goals
allow the users goals and their current score to be saved and loaded
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        int userInfo = 0;

        List<string> menu = new List<string>
        {
            "Menu Options: ",
            "1. Create new goal",
            "2. List goals",
            "3. Save goals",
            "4. Load goals",
            "5. Record event",
            "6. Quit"
        };
    
        while (userChoice != 6)
        {
            Console.WriteLine("Your score is " + userInfo);

            foreach (string menuList in menu)
            {
                Console.WriteLine(menuList);
            }            
            Console.WriteLine("Select a choice from the menu:");
            userChoice = int.Parse(Console.ReadLine());
                        switch (userChoice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
            }
        }
    }
}
