using System;

namespace AtvaltOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atvalt atvaltas = new Atvalt();

            // BinarisraValt tesztek
            Console.WriteLine("---- BinarisraValt tesztek ----");
            try
            {
                int decimálisSzám1 = 5;
                Console.WriteLine($"{decimálisSzám1} binárisra váltva: {atvaltas.BinarisraValt(decimálisSzám1)}"); // 5 -> 101
                int decimálisSzám2 = 15;
                Console.WriteLine($"{decimálisSzám2} binárisra váltva: {atvaltas.BinarisraValt(decimálisSzám2)}"); // 15 -> 1111
                int decimálisSzám3 = 0;
                Console.WriteLine($"{decimálisSzám3} binárisra váltva: {atvaltas.BinarisraValt(decimálisSzám3)}"); // 0 -> 0
                int decimálisSzám4 = -5;
                Console.WriteLine($"{decimálisSzám4} binárisra váltva: {atvaltas.BinarisraValt(decimálisSzám4)}"); // Hibát kell dobjon
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }

            // BinarisraValtStringes tesztek
            Console.WriteLine("\n---- BinarisraValtStringes tesztek ----");
            try
            {
                Console.WriteLine($"'5' binárisra váltva: {atvaltas.BinarisraValtStringes("5")}"); // 5 -> 101
                Console.WriteLine($"'0' binárisra váltva: {atvaltas.BinarisraValtStringes("0")}"); // 0 -> 0
                Console.WriteLine($"'-5' binárisra váltva: {atvaltas.BinarisraValtStringes("-5")}"); // Hibát kell dobjon
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }

            // DecimalisbaValt tesztek
            Console.WriteLine("\n---- DecimalisbaValt tesztek ----");
            try
            {
                string binárisSzám1 = "101";
                Console.WriteLine($"{binárisSzám1} decimálisra váltva: {atvaltas.DecimalisbaValt(binárisSzám1)}"); // 101 -> 5
                string binárisSzám2 = "1111";
                Console.WriteLine($"{binárisSzám2} decimálisra váltva: {atvaltas.DecimalisbaValt(binárisSzám2)}"); // 1111 -> 15
                string binárisSzám3 = "0";
                Console.WriteLine($"{binárisSzám3} decimálisra váltva: {atvaltas.DecimalisbaValt(binárisSzám3)}"); // 0 -> 0
                string binárisSzám4 = "-101";
                Console.WriteLine($"{binárisSzám4} decimálisra váltva: {atvaltas.DecimalisbaValt(binárisSzám4)}"); // Hibát kell dobjon
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }

            Console.WriteLine("\n---- DecimalisbaValtStringes tesztek ----");
            try
            {
                Console.WriteLine($"'101' decimálisra váltva: {atvaltas.DecimalisbaValtStringes("101")}"); // 101 -> 5
                Console.WriteLine($"'1111' decimálisra váltva: {atvaltas.DecimalisbaValtStringes("1111")}"); // 1111 -> 15
                Console.WriteLine($"'0' decimálisra váltva: {atvaltas.DecimalisbaValtStringes("0")}"); // 0 -> 0
                Console.WriteLine($"'-101' decimálisra váltva: {atvaltas.DecimalisbaValtStringes("-101")}"); // Hibát kell dobjon
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
