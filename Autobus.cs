using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Autobus : SrodekLokomocji
    {
        public Autobus(int IloscMiejsc)
        {
            this.iloscMiejsc = IloscMiejsc;
            ObliczCene();
        }

        public override string ToString()
        {
            return "Autobus: ilosc miejsc: " + this.iloscMiejsc + ", cena biletu: " + this.cenaBiletu;
        }


    }
}
