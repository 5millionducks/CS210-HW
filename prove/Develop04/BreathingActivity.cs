public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow=patterned breathing.")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(7);
        }
        DisplayEndingMessage();
    }
}