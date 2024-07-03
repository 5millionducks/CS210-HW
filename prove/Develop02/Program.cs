using System;

class Program
{
    static void Main(string[] args)
    {
        string _entryText = "";
        string randomPrompt = "";
        // string fullEntry = "";
        DisplayMessage();
        int menuNumber = -1;
        List<string> _entries = new List<string>();

        while (menuNumber != 5)
        {
            menuNumber = MenuChoice();
            if (menuNumber == 1)
            {
                _entries = new List<string>();
                 PromptGenerator promptGenerator = new PromptGenerator();
                randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                _entryText = Console.ReadLine();
                _entries.Add(randomPrompt);
                _entries.Add(_entryText);

            }
            else if (menuNumber == 2)
            {
                Entry anEntry = new Entry(GetDate(), randomPrompt, _entryText);
                string fullEntry = anEntry.GetEntryDisplay();
                Console.WriteLine(fullEntry);
            }

            else if (menuNumber == 3)
            {
                Console.WriteLine("This will be the Load");
                Journal myJournal = new Journal();
                string[] content = myJournal.LoadFromFile("journal.txt");
                string journal = string.Join(Environment.NewLine, content);
                Console.WriteLine(journal);
            }

            else if (menuNumber == 4)
            {
                Console.WriteLine("Entry Saved!");
                Journal myJournal = new Journal();
                string _promptText = _entries[0];
                string _entry = _entries[1];
                myJournal.SaveToFile(new Entry(GetDate(), _promptText, _entry).GetEntryDisplay());
           
            }
            if (menuNumber == 5)
            {
                System.Environment.Exit(0);
            }
        }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }

    static int MenuChoice()
    {
        Console.WriteLine(@"Please make a selection:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit");
        string menuResponse = Console.ReadLine();
        int menuNumber = int.Parse(menuResponse);
        return menuNumber;
    }
    static string GetDate() {
            DateTime dt = DateTime.Today;
            return dt.ToString("d");
    }

    }
}