using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Application started");
        
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Processing request {i} at {DateTime.Now}");
            System.Threading.Thread.Sleep(2000); // simulate work
        }

        Console.WriteLine("Application finished");
    }
}