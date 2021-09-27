using System;

namespace Uppgift_1_Pension
{
    class Program
    {
        static void Main(string[] args)
        {           
            // Frågar användaren om namn och ålder
            Console.WriteLine("Skriv in ditt för- och efternamn på en rad sedan ålder på en annan rad");
            string förnamnOchEfternamn = Console.ReadLine();
            // string efternamn = Console.ReadLine();
            int ålder = int.Parse(Console.ReadLine());

            // Deklarerar en variabel med uträkningen till pensionen
            int årKvar = 65 - ålder;

            // Deklarerar två formaterade strängar
            string omUnderSextio = string.Format("Hej {0}! Det är långt kvar tills du går i pension, närmare bestämt {1} år.", förnamnOchEfternamn, årKvar);

            string omÖverSextio = string.Format("Hej {0}! Du går snart i pension, närmare bestämt om {1} år.", förnamnOchEfternamn, årKvar);

            // If-sats med två olika utskrifter
            if (ålder < 60)
            {
                Console.WriteLine(omUnderSextio);
            }
            else
            {
                Console.WriteLine(omÖverSextio);
            }
 
        }
    }
}
