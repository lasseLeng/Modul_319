using System;

class Program
{
    static void Main()
    {
        Console.Write("Gib die Modul-Nummer ein: ");
        string modulNummer = Console.ReadLine();

        Console.Write("Gib die LB-Note ein: ");
        double lbNote = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gib die OBA-Note ein: ");
        double obaNote = Convert.ToDouble(Console.ReadLine());

        double modulNote = (lbNote * 0.8) + (obaNote * 0.2);

        Console.WriteLine($"Du hast im Modul M{modulNummer} die Note {modulNote:F2} erreicht. Diese setzt sich folgendermassen zusammen:");
        Console.WriteLine($"LB-Note (80%): {lbNote}");
        Console.WriteLine($"OBA (20%): {obaNote}");

        Console.ReadKey();
    }
}
