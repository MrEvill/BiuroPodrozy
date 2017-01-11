using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Podroz nowapodrozpieczarkipiotrka = new Podroz();

            Console.WriteLine("Zaplanuj swoja podroz!");
            Console.WriteLine("[A] - dodaj autobus");
            Console.WriteLine("[P] - dodaj samolot");
            Console.WriteLine("[U] - usun ostatnia pozycje z planu pozrozy");
            Console.WriteLine("[Z] - pokaz plan podrozy");
            Console.WriteLine("[D] - sprawdz date podrozy");

            char klawisz = char.Parse(Console.ReadLine());

            
            switch(klawisz)
                {
                case 'A':
                    {
                        Console.WriteLine("Ilosc miejsc:");
                        int iloscMiejsc = int.Parse(Console.ReadLine());

                        nowapodrozpieczarkipiotrka.DodajAutobus(iloscMiejsc);
                        break;
                    }
                case 'B':
                    {
                        Console.WriteLine("Ilosc miejsc:");
                        int iloscMiejsc = int.Parse(Console.ReadLine());

                        Console.WriteLine("Odleglosc:");
                        int odleglosc = int.Parse(Console.ReadLine());

                        nowapodrozpieczarkipiotrka.DodajSamolot(iloscMiejsc, odleglosc);
                        break;
                    }
            }
        }
    }
}
