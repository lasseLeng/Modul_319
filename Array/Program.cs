using System;

class Program
{
    static void Main(string[] args)
    {
        int[] noten = new int[5]; 

        Console.WriteLine("Bitte geben Sie 5 Noten ein:");

        for (int i = 0; i < noten.Length; i++)
        {
            Console.Write("Note " + (i + 1) + ": ");
            noten[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDie eingegebenen Noten sind:");
        for (int i = 0; i < noten.Length; i++)
        {
            Console.WriteLine("Zahl " + (i + 1) + ": " + noten[i]);
        }
        Console.ReadKey();
    }
}
