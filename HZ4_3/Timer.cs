using System;
using System.Threading;

public static class Timer
{
    public static void Start()
    {
        Console.Write("Geben Sie die Zeit in Sekunden f�r den Timer ein: ");
        int sekunden = int.Parse(Console.ReadLine());

        Console.WriteLine($"Timer gestartet f�r {sekunden} Sekunden.");

        for (int i = sekunden; i > 0; i--)
        {
            Console.WriteLine($"Noch {i} Sekunden...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Zeit ist abgelaufen!");
        Console.ReadKey();
    }
}
