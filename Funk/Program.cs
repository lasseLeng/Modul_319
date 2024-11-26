using System;
using System.Threading;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wählen Sie eine der folgenden Optionen:");
        Console.WriteLine("1 - Stoppuhr");
        Console.WriteLine("2 - Timer");
        Console.WriteLine("3 - Normale Uhr");
        Console.Write("Ihre Wahl: ");

        string auswahl = Console.ReadLine();

        switch (auswahl)
        {
            case "1":
                Stoppuhr.Start();
                break;
            case "2":
                Timer.Start();
                break;
            case "3":
                Uhr.Start();
                break;
            default:
                Console.WriteLine("Ungültige Auswahl. Programm wird beendet.");
                break;
        }
    }

}

public static class Stoppuhr
{
    public static void Start()
    {
        Console.WriteLine("Bitte geben Sie die bisherige Bestzeit in Sekunden an: ");
        int bestZeit = Convert.ToInt32(Console.ReadLine());

        int aktuelleZeit = 0;

        Console.WriteLine("Stoppuhr gestartet. Drücken Sie eine beliebige Taste, um sie zu stoppen.");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        do
        {
            Console.Clear();
            aktuelleZeit = (int)stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine($"Verstrichene Zeit: {aktuelleZeit} Sekunden");
            Thread.Sleep(1000);
        } while (!Console.KeyAvailable);

        stopwatch.Stop();
        Console.ReadKey();

        Console.WriteLine($"Gestoppte Zeit: {aktuelleZeit} Sekunden");
        if (aktuelleZeit < bestZeit)
        {
            Console.WriteLine("Herzlichen Glückwunsch! Sie haben eine neue Bestzeit erreicht!");
        }
        else
        {
            Console.WriteLine("Die Bestzeit wurde leider nicht geschlagen.");
        }
        Console.ReadKey();
    }

}
public static class Timer
{
    public static void Start()
    {
        Console.Write("Geben Sie die Zeit in Sekunden für den Timer ein: ");
        int sekunden = int.Parse(Console.ReadLine());

        Console.WriteLine($"Timer gestartet für {sekunden} Sekunden.");

        for (int i = sekunden; i > 0; i--)
        {
            Console.WriteLine($"Noch {i} Sekunden...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Zeit ist abgelaufen!");
        Console.ReadKey();
    }
}
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
