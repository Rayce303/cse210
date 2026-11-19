class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create a new goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayCreateGoalMenu()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Checklist Goal");
        Console.WriteLine("  3. Eternal Goal");
        Console.Write("What type of goal do you want to create? ");
        return int.Parse(Console.ReadLine());
    }
}