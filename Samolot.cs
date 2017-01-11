using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Samolot : SrodekLokomocji
    {
        private int odleglosc;

        public override void ObliczCene()
        {
            if (this.odleglosc > 200)
            {
                this.cenaBiletu = odleglosc * 2.56;
            }
            else
            {
                this.cenaBiletu = 24;
            }
        }

        public Samolot(int IloscMiejsc, int Odleglosc)
        {
            this.iloscMiejsc = IloscMiejsc;
            this.odleglosc = Odleglosc;
            this.ObliczCene();
        }

        public override string ToString()
        {
            return "Samolot: ilosc miejsc: " + this.iloscMiejsc + ", odleglosc: " + this.odleglosc + ", cena biletu: " + this.cenaBiletu;
        }

    }


}
