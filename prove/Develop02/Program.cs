using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;
        JournalEntry newEntry = new JournalEntry();
        Journal journalObjectWoo = new Journal();

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.WriteLine();
                    newEntry.CreateJournalEntry();
                    journalObjectWoo.AddEntry(newEntry);
                    break;
                case 2:
                    Console.WriteLine();
                    journalObjectWoo.DisplayJournal();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Enter the filename: ");
                    string saveFile = Console.ReadLine();
                    journalObjectWoo.WriteToFile(saveFile);
                    break;
                case 4:
                    Console.Write("Enter the filename: ");
                    string loadFile = Console.ReadLine();
                    journalObjectWoo.ReadFromFile(loadFile);
                    break;
            }
        }
    }
}