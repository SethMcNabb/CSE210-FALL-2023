using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
    Lectures l1 = new Lectures("Mindfullness","A scientific deep dive into the benefits of mindfullness","2/24/2024","10AM","David Doe",75, new Address("1404 Rolling Hills Dr","Pensicola","FL"));
    Receptions r1 = new Receptions("John's retirement party","Join us as we celebrate John's 41 years of hard work!","5PM","1/22/2024",20, new Address("649 Event Center Cr","Richmond","VA"));
    OutdoorGatherings o1 = new OutdoorGatherings("Annual turkey shoot","5th annual 7th ward turkey shoot","12/18/2023","1pm","sunny", new Address("120 Underwood St","Forks","WA"));
    
        Console.WriteLine("Lecture Event");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(l1.StandardDetails());
        Console.WriteLine("Full Details:");
        Console.WriteLine(l1.FullDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(l1.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(r1.StandardDetails());
        Console.WriteLine("Full Details:");
        Console.WriteLine(r1.FullDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(r1.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(o1.StandardDetails());
        Console.WriteLine("Full Details:");
        Console.WriteLine(o1.FullDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(o1.ShortDescription());  
    
    }
}