using System;

public class Program
{
    private static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");
            Console.Write("Please choose an activity: ");
            string _choice = Console.ReadLine();

            switch (_choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new();
                    breathingActivity.Start();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.Start();
                    break;
                case "3":
                    ListingActivity listingActivity = new();
                    listingActivity.Start();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Uh Oh! Something went wrong, please try again!");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}