﻿﻿﻿﻿﻿﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocitani
{
    internal class Program
    {
        // Odebráno: private static Random random = new Random();

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

            // Faktoriál
            Console.WriteLine("--- FAKTORIÁL ---");
            int faktorialCislo = -1;
            while (faktorialCislo < 0)
            {
                Console.Write("Zadejte nezáporné celé číslo pro výpočet faktoriálu: ");
                faktorialCislo = ZiskatCislo();
                if (faktorialCislo < 0)
                {
                    Console.WriteLine("Faktoriál je definován pouze pro nezáporná čísla.");
                }
            }

            long faktorialVysledek = 1;
            // Faktoriál 0 je 1, pro ostatní počítáme
            if (faktorialCislo > 0) 
            {
                for (int i = 1; i <= faktorialCislo; i++)
                {
                    // Kontrola přetečení (i když long má velký rozsah)
                    try
                    {
                        faktorialVysledek = checked(faktorialVysledek * i);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine($"Výsledek faktoriálu pro {faktorialCislo} je příliš velký pro typ long.");
                        faktorialVysledek = -1; // Indikace chyby
                        break;
                    }
                }
            }
            
            if (faktorialVysledek != -1) // Pokud nedošlo k přetečení
            {
                 Console.WriteLine($"Faktoriál čísla {faktorialCislo} je {faktorialVysledek}.");
            }
            Console.WriteLine();


            // Modulo (Zbytek po dělení)
            Console.WriteLine("--- MODULO (ZBYTEK PO DĚLENÍ) ---");
            Console.Write("Zadejte dělenec (číslo, ze kterého se počítá zbytek): ");
            int modulo1 = ZiskatCislo();
            int modulo2 = 0;
            bool validModuloDivisor = false;

            while (!validModuloDivisor)
            {
                Console.Write("Zadejte dělitel (číslo, kterým se dělí pro zbytek): ");
                modulo2 = ZiskatCislo();
                if (modulo2 != 0)
                {
                    validModuloDivisor = true;
                }
                else
                {
                    Console.WriteLine("Dělení nulou není povoleno. Zadejte jiné číslo.");
                }
            }

            int zbytek = modulo1 % modulo2;
            Console.WriteLine($"Zbytek po dělení čísla {modulo1} číslem {modulo2} je {zbytek}.");
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
