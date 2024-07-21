using System.Collections.Generic;

public class ListingActivity : Activity
{
    private readonly List<string> _prompts =
    [
        "What things you are grateful for?",
        "Write things you are proud of yourself for.",
        "What are some of your favorite scriptures, and why?",
        "What are some hobbies of yours?",
        "Who do you use as role models?"
    ];

    public ListingActivity() : base("Listing", "This activity will help you see the good in your life by listing as many answers to the question as you can.")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        Random random = new();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Start thinking about your answers...");
        ShowCountDown(5);
        List<string> responses = [];
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            responses.Add(Console.ReadLine());
        }
        DisplayEndingMessage();
    }
}