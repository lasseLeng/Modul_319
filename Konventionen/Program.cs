using System;

class Program
{
    static void Main()
    {
        // Eingaben
        Console.Write("Gib die Grundstücksgröße in Quadratmetern ein: ");
        double grundstuecksGroesse = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gib den Preis pro Quadratmeter ein: ");
        double preisProQuadratmeter = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gib die Mehrwertsteuer in Prozent ein: ");
        double mehrwertsteuerProzent = Convert.ToDouble(Console.ReadLine());

        // Verarbeitung
        double gesamtpreisOhneMwst = grundstuecksGroesse * preisProQuadratmeter;
        double mehrwertsteuer = gesamtpreisOhneMwst * (mehrwertsteuerProzent / 100);
        double gesamtpreisMitMwst = gesamtpreisOhneMwst + mehrwertsteuer;

        // Ausgabe
        Console.WriteLine($"Der Gesamtwert des Grundstücks beträgt {gesamtpreisMitMwst:F2} EUR inklusive {mehrwertsteuerProzent}% Mehrwertsteuer.");
        Console.WriteLine($"(Nettopreis: {gesamtpreisOhneMwst:F2} EUR, Mehrwertsteuer: {mehrwertsteuer:F2} EUR)");

        Console.ReadKey();
    }
}
