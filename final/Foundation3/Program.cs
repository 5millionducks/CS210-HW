using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("33410 Please Street", "Menifee", "CA", "92584");
        Address address2 = new("2649 Sleepy Circle", "Mammoth Lakes", "California", "92562");
        Address address3 = new("87894 Tired Lane", "Pocatello", "Idaho", "83203");

        Lecture lecture = new("Creating Joy in Any Circumstance", "Learn how to persevere!", "10-11-2024", "5:00 PM", address1, "Doctor Dew", 225);

        Reception reception = new("Stratford Wedding", "Celebrate the Stratfords", "04-11-2025", "6:00 PM", address2, "stratfordweddingdetails@gmail.com");

        OutdoorGathering outdoorGathering = new("Farmer's Market", "Vendors with food, flowers, trinkets, and more", "07-27-2024", "10:00 AM", address3, "Sunny");

        Console.WriteLine("Lecture, standard: " + lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Lecture, full: " + lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Lecture, description: " + lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("Reception, standard:" + reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Reception, full: " + reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Reception, description: " + reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering, standard: " + outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering, full: " + outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering, description: " + outdoorGathering.GetShortDescription());
    }
    
}