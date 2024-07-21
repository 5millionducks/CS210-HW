using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private readonly List<string> _prompts =
    [
        "When was a time you stood up for your beliefs?",
        "What is the hardest thing you have overcome?",
        "Do you have a favorite service story?",
        "Describe a time you were selfless."
    ];

    private readonly List<string> _questions =
    [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "How can you keep this experience in mind in the future?"
    ];

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have.")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        Random random = new();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}