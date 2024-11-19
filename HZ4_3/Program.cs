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
