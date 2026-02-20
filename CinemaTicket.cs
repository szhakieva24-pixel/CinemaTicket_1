using System;

class Program
{
    static void Main()
    {
        Console.Write("Movie Title: ");
        string title = Console.ReadLine();

        Console.Write("Number of Tickets: ");
        int tickets = Convert.ToInt32(Console.ReadLine());

        Console.Write("Price per Ticket: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Duration of Movie in hours: ");
        double duration = Convert.ToDouble(Console.ReadLine());

        Console.Write("Screen Number: ");
        int screen = Convert.ToInt32(Console.ReadLine());

        Console.Write("First Letter of Seat Row: ");
        string row = Console.ReadLine();

        Console.Write("Is 3D Movie (true/false): ");
        bool is3D = Convert.ToBoolean(Console.ReadLine());

        double totalCost = tickets * price;
        double costPerHour = totalCost / duration;

        Console.WriteLine("Movie Title: " + title);
        Console.WriteLine("Number of Tickets: " + tickets);
        Console.WriteLine("Price per Ticket: " + price);
        Console.WriteLine("Duration of Movie in hours: " + duration);
        Console.WriteLine("Screen Number: " + screen);
        Console.WriteLine("First Letter of Seat Row: " + row);
        Console.WriteLine("Is 3D Movie: " + is3D);
        Console.WriteLine("Total Ticket Cost: " + totalCost);
        Console.WriteLine("Cost per Hour of Movie: " + costPerHour);
    }
}
