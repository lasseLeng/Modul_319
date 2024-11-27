using System;

class Program
{
    static void Main(string[] args)
    {
        // Definiere die Größe des Arrays
        int[] zahlen = new int[5]; // Array mit Platz für 5 Zahlen

        Console.WriteLine("Bitte geben Sie 5 Zahlen ein:");

        // Eingabe der Zahlen
        for (int i = 0; i < zahlen.Length; i++)
        {
            Console.Write("Zahl " + (i + 1) + ": ");
            zahlen[i] = int.Parse(Console.ReadLine());
        }

        // Ausgabe der Zahlen
        Console.WriteLine("\nDie eingegebenen Zahlen sind:");
        for (int i = 0; i < zahlen.Length; i++)
        {
            Console.WriteLine("Zahl " + (i + 1) + ": " + zahlen[i]);
        }
    }
}
