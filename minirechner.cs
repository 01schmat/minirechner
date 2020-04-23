using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int ErsteZahl = 0;
            int ZweitZahl = 0;
            int RechenOperation = 0;
            int Ergebnis = 0;
            string Add = "";
            string Sub = "";
            string Mul = "";
            string Div = "";

            Console.WriteLine("Bitte geben Sie die erste zahl ein:");
            ErsteZahl = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Bitte geben sie die zweite Zahl ein:");
            ZweitZahl = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Bitte wählen Sie eine RechenOperation [1 Addieren | 2 Subtrahieren | 3 Multiplizieren | 4 Dividieren]:");
            RechenOperation = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (RechenOperation == 1)   // Addieren
            {
                Ergebnis = Addieren(ErsteZahl, ZweitZahl);
                Add = "addiert mit";
                Console.WriteLine(ErsteZahl + " " + Add + " " +ZweitZahl + " ergibt: " + Ergebnis);
            }

            
            if (RechenOperation == 2)   // Subtrahieren
            {
                Ergebnis = Subtrahieren(ErsteZahl, ZweitZahl);
                Sub = "subtrahiert mit";
                Console.WriteLine(ErsteZahl + " " + Sub + " " + ZweitZahl + " ergibt: " + Ergebnis);
            }
             

            
            if (RechenOperation == 3)   // Multiplizieren
            {
                Ergebnis = Multiplizieren(ErsteZahl, ZweitZahl);
                Mul = "multipliziert mit";
                Console.WriteLine(ErsteZahl + " " + Mul + " " + ZweitZahl + " ergibt: " + Ergebnis);
            }
             

            /*
            if (RechenOperation == 4)   // Dividieren
            {
                Ergebnis = Dividieren(ErsteZahl, ZweitZahl);
                Div = "dividiert mit";
                Console.WriteLine(ErsteZahl + " " + Div + " " + ZweitZahl + " ergibt: " + Ergebnis);
            }
             */

            Console.ReadKey();
        }

        // Metohden

        static int Addieren(int zahl1, int zahl2)
        {
            int Lösung = zahl1 + zahl2;
            return Lösung;
        }

        
        static int Subtrahieren(int zahl1, int zahl2)
        {
            int Lösung = zahl1 - zahl2;
            return Lösung;
        }
         

        
        static int Multiplizieren(int zahl1, int zahl2)
        {
            int Lösung = zahl1 * zahl2;
            return Lösung;
        }
         

        /*
        static int Dividieren(int zahl1, int zahl2)
        {
            int Lösung = zahl1 / zahl2;
            return Lösung;
        }
         */
    }
}
