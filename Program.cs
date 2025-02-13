using System;
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
            Console.WriteLine("Ahoj, vítejte v Jednoduché konzolové aplikaci!");

            // Provedení jednoduchých aritmetických operací
            Console.WriteLine("Uděláme několik jednoduchých aritmetických operací.");

            // Sčítání
            int cislo1 = 10;
            int cislo2 = 20;
            int soucet = cislo1 + cislo2;
            Console.WriteLine($"Součet čísel {cislo1} a {cislo2} je {soucet}.");

            // Odčítání
            int rozdil = cislo2 - cislo1;
            Console.WriteLine($"Rozdíl mezi čísly {cislo2} a {cislo1} je {rozdil}.");

            // Násobení
            int soucin = cislo1 * cislo2;
            Console.WriteLine($"Součin čísel {cislo1} a {cislo2} je {soucin}.");

            // Dělení
            if (cislo2 != 0)
            {
                double podil = (double)cislo1 / cislo2;
                Console.WriteLine($"Podíl čísla {cislo1} vyděleného číslem {cislo2} je {podil}.");
            }
            else
            {
                Console.WriteLine("Dělení nulou není povoleno.");
            }

            // Čekání na stisk klávesy před ukončením
            Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení...");
            Console.ReadKey();
        }

    }
}
