using System;

class Program
{
    static void Main(string[] args)
    {
        Goals myGoals = new Goals();
        Menu theMenu = new Menu();
        
        int choice = 0;

        Console.Clear();
        while(choice != 6)
        {
            myGoals.DisplayScore();

            choice = theMenu.DisplayMenu();

            switch(choice)
            {
                case 1:
                    int whichKind = theMenu.DisplayCreateGoalMenu();

                    switch(whichKind)
                    {
                        case 1:
                            SimpleGoal theSimpleGoal = new SimpleGoal();
                            myGoals.AddGoal(theSimpleGoal);
                            break;
                        case 2:
                            ChecklistGoal theChecky = new ChecklistGoal();
                            myGoals.AddGoal(theChecky);
                            break;
                        case 3:
                            EternalGoal eternal = new EternalGoal();
                            myGoals.AddGoal(eternal);
                            break;
                    }
                    break;
                case 2:
                    myGoals.DisplayGoals();
                    break;
                case 3:
                    myGoals.SaveGoals();
                    break;
                case 4:
                    myGoals.LoadGoals();
                    break;
                case 5:
                    myGoals.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Okay, have fun. Go make cookies.");
                    break;
            }
        }
    }
}