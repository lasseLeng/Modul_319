using System;

class Program
{
    static void Main()
    {
        Console.Write("Gib die Modul-Nummer ein: ");
        string modulNummer = Console.ReadLine();

        Console.Write("Gib die LB-Note ein: ");
        double lbNote = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gib die OBA-Punkte für Aufgabenkontrolle 1 ein: ");
        double obaPunkteAK1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gib die OBA-Punkte für Aufgabenkontrolle 2 ein: ");
        double obaPunkteAK2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gib die OBA-Punkte für Portfolioartikel ein: ");
        double obaPunktePortfolio = Convert.ToDouble(Console.ReadLine());

        double obaNote = (obaPunkteAK1 + obaPunkteAK2 + obaPunktePortfolio) / 3.0;

        double modulNote = (lbNote * 0.8) + (obaNote * 0.2);

        Console.WriteLine($"Du hast im Modul M{modulNummer} die Note {modulNote:F2} erreicht. Diese setzt sich folgendermassen zusammen:");
        Console.WriteLine($"LB-Note (80%): {lbNote}");
        Console.WriteLine($"OBA (20%): {obaNote:F2}");
        Console.WriteLine($"Aufgabenkontrolle 1: {obaPunkteAK1}");
        Console.WriteLine($"\tAufgabenkontrolle 2: {obaPunkteAK2}");
        Console.WriteLine($"\tPortfolio-Artikel: {obaPunktePortfolio}");

        Console.ReadKey();
    }
}
