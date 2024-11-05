using System;

class Program
{
    static void Main()
    {
        int zahl;
        do
        {
            Console.Write("Gib eine positive Zahl ein: ");
            zahl = Convert.ToInt32(Console.ReadLine());

            if (zahl <= 0)
            {
                Console.WriteLine("Das ist keine Positive Zahl");
            }

        } while (zahl <= 0); 

        Console.WriteLine($"Das 1x1 mit der Zahl {zahl}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{zahl} x {i} = {zahl * i}");
        }

        Console.ReadKey();
    }
}
