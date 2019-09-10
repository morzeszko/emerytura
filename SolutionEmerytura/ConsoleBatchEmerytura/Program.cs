using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBatchEmerytura
{
    class Program
    {
const int wiekEmerytalny = 65;
        static void Main(string[] args)
        {
     
                Console.WriteLine("Aplikacja EMERYTURA");

            if (args.Length !=2)
            {
                Console.WriteLine("Brak danych");
                return; //wychodzimy z main
            }

                string imie = args[0];

                Console.WriteLine($"Witaj {imie}!");

                int wiek = int.Parse(args[1]); //Parse sprawdza czy tekst da się przerobić na liczbę
                if (wiek < wiekEmerytalny)
                {
                    Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lat do emerytury");
                }
                else
                {
                    Console.WriteLine("Jesteś emerytem.");
                }
                Console.ReadKey(); // oczekuje na naciśnięcie dowolnego klawisza

            }
    }
}
