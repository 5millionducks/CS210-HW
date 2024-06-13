using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string valueInText = Console.ReadLine();
        int grade = int.Parse(valueInText);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Grade: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed.");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
        }
    }