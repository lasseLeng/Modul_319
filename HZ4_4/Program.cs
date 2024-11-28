using System;

class SchulnotenProgramm
{
    // Globale Konstante: Maximale Anzahl an Noten
    const int MAX_NOTEN = 5;

    // Globale Variable: Name des Programms
    static string programmName = "Schulnoten-Berechnung";

    static void Main(string[] args)
    {
        // Lokale Variable: Array zur Speicherung der Noten
        double[] noten = new double[MAX_NOTEN];

        Console.WriteLine($"Willkommen im Programm: {programmName}");
        Console.WriteLine($"Sie können bis zu {MAX_NOTEN} Schulnoten eingeben.");

        // Eingabe der Noten
        for (int i = 0; i < MAX_NOTEN; i++)
        {
            Console.Write($"Bitte geben Sie Note {i + 1} ein: ");
            noten[i] = double.Parse(Console.ReadLine());
        }

        // Berechnung des Durchschnitts
        double durchschnitt = BerechneDurchschnitt(noten);

        // Block-spezifische Variable: Bewertung des Durchschnitts
        {
            string bewertung;
            if (durchschnitt <= 1.5)
                bewertung = "Sehr gut";
            else if (durchschnitt <= 2.5)
                bewertung = "Gut";
            else if (durchschnitt <= 3.5)
                bewertung = "Befriedigend";
            else if (durchschnitt <= 4.5)
                bewertung = "Ausreichend";
            else
                bewertung = "Mangelhaft";

            Console.WriteLine($"Der Durchschnitt der Noten ist: {durchschnitt:F2}");
            Console.WriteLine($"Ihre Leistung wird als '{bewertung}' bewertet.");
        }

        Console.WriteLine("Vielen Dank fürs Benutzen des Programms!");
    }

    // Methode zur Berechnung des Durchschnitts
    static double BerechneDurchschnitt(double[] noten)
    {
        // Lokale Variable: Summe der Noten
        double summe = 0;

        for (int i = 0; i < noten.Length; i++)
        {
            summe += noten[i];
        }

        return summe / noten.Length;
    }
}
