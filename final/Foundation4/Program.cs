using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running("Jul 11 2024", 40, 60.0),
            new Cycling("May 23 2024", 25, 70.0),
            new Swimming("Jun 18 2024", 60, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}