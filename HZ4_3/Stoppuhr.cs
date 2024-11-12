using System;
using System.Diagnostics;
using System.Threading;

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
