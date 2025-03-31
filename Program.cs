﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocitani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uvítání 
            Console.WriteLine("Ahoj, vítejte v Jednoduché konzolové aplikaci pro počítání!");
            Console.WriteLine("Budete zadávat čísla pro různé aritmetické operace.");
            Console.WriteLine();

            // Sčítání
            Console.WriteLine("--- SČÍTÁNÍ ---");
            Console.Write("Zadejte první číslo pro sčítání: ");
            int scitani1 = ZiskatCislo();
            Console.Write("Zadejte druhé číslo pro sčítání: ");
            int scitani2 = ZiskatCislo();
            int soucet = scitani1 + scitani2;
            Console.WriteLine($"Součet čísel {scitani1} a {scitani2} je {soucet}.");
            Console.WriteLine();

            // Odčítání
            Console.WriteLine("--- ODČÍTÁNÍ ---");
            Console.Write("Zadejte první číslo pro odčítání: ");
            int odcitani1 = ZiskatCislo();
            Console.Write("Zadejte druhé číslo pro odčítání (bude odečteno od prvního): ");
            int odcitani2 = ZiskatCislo();
            int rozdil = odcitani1 - odcitani2;
            Console.WriteLine($"Rozdíl mezi čísly {odcitani1} a {odcitani2} je {rozdil}.");
            Console.WriteLine();

            // Násobení
            Console.WriteLine("--- NÁSOBENÍ ---");
            Console.Write("Zadejte první číslo pro násobení: ");
            int nasobeni1 = ZiskatCislo();
            Console.Write("Zadejte druhé číslo pro násobení: ");
            int nasobeni2 = ZiskatCislo();
            int soucin = nasobeni1 * nasobeni2;
            Console.WriteLine($"Součin čísel {nasobeni1} a {nasobeni2} je {soucin}.");
            Console.WriteLine();

            // Dělení
            Console.WriteLine("--- DĚLENÍ ---");
            Console.Write("Zadejte dělenec (číslo, které bude děleno): ");
            int deleni1 = ZiskatCislo();
            int deleni2 = 0;
            bool validDivisor = false;
            
            while (!validDivisor)
            {
                Console.Write("Zadejte dělitel (číslo, kterým se bude dělit): ");
                deleni2 = ZiskatCislo();
                if (deleni2 != 0)
                {
                    validDivisor = true;
                }
                else
                {
                    Console.WriteLine("Dělení nulou není povoleno. Zadejte jiné číslo.");
                }
            }
            
            double podil = (double)deleni1 / deleni2;
            Console.WriteLine($"Podíl čísla {deleni1} vyděleného číslem {deleni2} je {podil}.");
            Console.WriteLine();

            // Mocniny
            Console.WriteLine("--- MOCNINY ---");
            Console.Write("Zadejte číslo pro výpočet mocnin: ");
            int mocninyZaklad = ZiskatCislo();
            Console.Write("Zadejte exponent (na kolikátou mocninu): ");
            int exponent = ZiskatCislo();
            double mocnina = Math.Pow(mocninyZaklad, exponent);
            Console.WriteLine($"{mocninyZaklad} na {exponent}. mocninu je {mocnina}.");
            Console.WriteLine();

            // Odmocniny
            Console.WriteLine("--- ODMOCNINY ---");
            int odmocninyZaklad = 0;
            bool validRoot = false;
            
            while (!validRoot)
            {
                Console.Write("Zadejte číslo pro výpočet odmocniny (musí být kladné): ");
                odmocninyZaklad = ZiskatCislo();
                if (odmocninyZaklad >= 0)
                {
                    validRoot = true;
                }
                else
                {
                    Console.WriteLine("Pro výpočet reálné odmocniny je potřeba zadat kladné číslo.");
                }
            }
            
            double odmocnina = Math.Sqrt(odmocninyZaklad);
            Console.WriteLine($"Druhá odmocnina čísla {odmocninyZaklad} je {odmocnina:F2}.");
            Console.WriteLine();

            // Čekání na stisk klávesy před ukončením
            Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení...");
            Console.ReadKey();
        }

        // Pomocná metoda pro získání čísla od uživatele s ošetřením vstupu
        static int ZiskatCislo()
        {
            int cislo;
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.Write("Neplatný vstup. Zadejte prosím celé číslo: ");
            }
            return cislo;
        }
    }
}
