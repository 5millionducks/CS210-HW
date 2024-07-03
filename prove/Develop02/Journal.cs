using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
    }

    public void SaveToFile(string newEntry)
    {
        using (StreamWriter writer = new StreamWriter("journal.txt", true))
    {
        writer.WriteLine(newEntry);
    }
    }

    public string[] LoadFromFile(string journal)
    {
        return File.ReadAllLines("journal.txt");

    }
}