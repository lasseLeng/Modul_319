
//Bibliotheken, die Funktionen zur Verfügung stellen
using System;

//Namensbereich, Container für Organisation des Codes
namespace Code1
{
    //Codeblock, durch geschweifte Klammern begrenzt
    //Klasse, beinhaltet Code für Daten und Algorithmen
    class Program
    {
        // Konstante
        const double Pi = 3.14159;

        //Methode, eine Funktion, die ausgeführt werden kann
        //Main-Methode, hier startet die Anwendung
        static void Main(string[] args)
        {
            // Verschiedene Datentypen und Variablen
            // Der Datentyp legt fest, welche Art von Daten in der Variable gespeichert werden.
            int alter = 16;                          // Ganzzahl
            double Note = 5.5;                       // Gleitkommazahl
            bool Schülerausweis = true;              // Boolescher Wert
            char initial = 'A';                      // Einzelnes Zeichen
            string name = "Lasse";                   // Zeichenkette

            // Ausgabe der Variablen
            //Anweisungen durch Semikolon getrennt
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Alter: " + alter);
            Console.WriteLine("erwartete Note: " + Note);
            Console.WriteLine("Schülerausweis erhalten: " + Schülerausweis);
            Console.WriteLine("Blutgruppe: " + initial);

            // Verwendung der Konstante
            double kreisRadius = 5.0;
            double flaeche = Pi * kreisRadius * kreisRadius;
            Console.WriteLine("Die Fläche des Kreises mit Radius " + kreisRadius + " ist: " + flaeche);

            // Änderung der Variablenwerte
            alter += 1; // erhöht das Alter um 1

            // Aktualisierte Werte ausgeben
            Console.WriteLine("Neues Alter: " + alter);
        }
    }
}

