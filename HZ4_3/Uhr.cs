using System;
using System.Threading;

public static class Uhr
{
    public static void Start()
    {
        Console.WriteLine("Drücken Sie eine beliebige Taste, um die Uhr zu beenden.");

        while (!Console.KeyAvailable)
        {
            Console.Clear();
            Console.WriteLine("Aktuelle Uhrzeit: " + DateTime.Now.ToString("HH:mm:ss"));
            Thread.Sleep(1000); 
        }

        Console.ReadKey(); 
    }
}
