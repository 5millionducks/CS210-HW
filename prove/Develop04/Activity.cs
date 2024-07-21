using System;
using System.Threading;

public class Activity(string name, string description)
{
    protected string _name = name;
    protected string _description = description;
    protected int _time;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Start {_name} activity.");
        Console.WriteLine(_description);
        Console.Write("Enter the duration: ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine($"{_name} beginning now");
        Thread.Sleep(3000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You completed {_name} for {_time} seconds");
        Thread.Sleep(3000);
    }

    public static void ShowSpinner(int _time)
    {
        for (int i = 0; i < _time; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public static void ShowCountDown(int _time)
    {
        for (int i = _time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
