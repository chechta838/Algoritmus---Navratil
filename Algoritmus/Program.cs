using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmus
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> cisla = new List<int>() {1,2,3,4,5,6,7,8,9 };

            while (true)
            {
                Console.WriteLine("NAVIGACE");
                Console.WriteLine("--------");
                Console.WriteLine("A -> Pripojit číslo do seznamu");
                Console.WriteLine("B -> zobrazit seznam");
                Console.WriteLine("C -> seřadí nám čísla od největšího po nejmenší");
                Console.WriteLine("D -> seřadí nám čísla od nejmenšího po největší");
                Console.WriteLine("E -> Zobrazí nám nejmenší a největší číslo v seznamu");
                Console.WriteLine("F -> Zobrazí čísla větší než hodnotami uživatelem zvolená");
                Console.WriteLine("G -> Zvolíme dělite");
                Console.WriteLine("H -> Vypíší se nám sudá čísla");
                Console.WriteLine("I -> Odebere nám zvolené číslo(hodnota né jeho index)");
                Console.WriteLine("Q -> Vypnutí programu");

                Console.WriteLine("---------------------------------------------");

                ConsoleKeyInfo navigation = Console.ReadKey();
                Console.WriteLine();


                if (navigation.Key == ConsoleKey.A)
                {
                    Console.WriteLine("Přidejte číslo");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Zadejte číslo, které chcete přidat:");
                    int cislo = int.Parse(Console.ReadLine());
                    cisla.Add(cislo);


                }
                else

                    if (navigation.Key == ConsoleKey.B)
                {
                    Console.WriteLine("Seznam čísel: " + string.Join(", ", cisla));
                }
                else

                if (navigation.Key == ConsoleKey.C)
                {
                    cisla.Sort((a, b) => b.CompareTo(a));
                }
                else
                if (navigation.Key == ConsoleKey.D)
                {
                    cisla.Sort((a, b) => a.CompareTo(b));
                }
                if (navigation.Key == ConsoleKey.E)
                {
                    int nejvetsi = cisla.Max();
                    int nejmensi = cisla.Min();
                    Console.WriteLine("Naše největší číslo je:" + " " + nejvetsi);
                    Console.WriteLine("Naše nejmenší číslo je:" + " " + nejmensi);
                }
                else
                if (navigation.Key == ConsoleKey.F)
                {
                    Console.Write("Zadejte hodnotu pro vyhledání většího čísla: ");
                    string enter = Console.ReadLine();
                    int hodnota = int.Parse(enter);

                    List<int> vetsiHod = cisla.Where(cislo => cislo > hodnota).ToList();
                    Console.WriteLine("Čísla větší než: " + hodnota);
                    foreach (int cislo in vetsiHod)
                    {
                        Console.WriteLine(cislo);
                    }
                }
                else
                if (navigation.Key == ConsoleKey.G)
                {
                    Console.Write("Zadejte jakým dělitelem hledáte čísla?");
                    string vstup = Console.ReadLine();
                    int value = int.Parse(vstup);

                    List<int> delitel = cisla.Where(cislo => cislo % value == 0).ToList();
                    Console.WriteLine("Čísla dělitelná:" + " " + value);
                    foreach (int cislo in delitel)
                    {
                        Console.WriteLine(cislo);
                    }
                }
                else
                if (navigation.Key == ConsoleKey.H)
                {
                    List<int> sudaCisla = cisla.Where(cislo => cislo % 2 == 0).ToList();

                    foreach (int cislo in sudaCisla)
                    {
                        Console.WriteLine(cislo);
                    }

                }
                else
                if (navigation.Key == ConsoleKey.I)
                {
                    Console.Write("Zadejte jaké číslo chcete smazat");
                    string cislomaz = Console.ReadLine();
                    int remove = int.Parse(cislomaz);
                    if (cisla.Contains(remove))
                    {
                        cisla.Remove(remove);
                        Console.WriteLine("Číslo bylo úspěšně smazáno");
                    }
                    else
                        Console.WriteLine("Číslo v seznamu není");
                }
                else
                if (navigation.Key == ConsoleKey.Q)
                {
                    Environment.Exit(0);
                }


            }
        }
    }
}
