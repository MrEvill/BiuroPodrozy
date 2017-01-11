using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Podroz : IData, IZarzadzaj
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy = new List<SrodekLokomocji>();
        private double koszt = 200;

        public void DodajAutobus(int iloscMiejsc)
        {
            planPodrozy.Add(new Autobus(iloscMiejsc));
            //this.koszt += cenaBiletu;
        }

        public void DodajSamolot(int iloscMiejsc, int odleglosc)
        {
            planPodrozy.Add(new Samolot(iloscMiejsc, odleglosc));
        }
        public void UsunOstatni()
        {
            planPodrozy.RemoveAt(planPodrozy.Count - 1);
        }
        public void Wyczysc()
        {
            planPodrozy.Clear();
        }

        public void UstawDate(DateTime data)
        {
            this.dataPodrozy = data;
        }
        public bool SprawdzDate()
        {
            if (dataPodrozy > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string plan = "";

            foreach (var e in planPodrozy)
            {
                plan += e + "\n";
            }
            return plan;
        }
    }
}
