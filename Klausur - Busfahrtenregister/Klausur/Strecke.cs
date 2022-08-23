using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur
{
    class Strecke
    {
        private Fahrt fahrt;
        private int anzahl;
        private float gesamtStrecke;
        public Strecke(Fahrt fahrt, int anzahl)
        {
            this.fahrt = fahrt;
            this.anzahl = anzahl;
            gesamtStrecke = fahrt.entfernung * anzahl;
        }
        
        public override string ToString()
        {
            return fahrt.ToString() + " x " + anzahl + " => " + gesamtStrecke + "km";
        }

        public float GetGesamtStrecke()
        {
            return gesamtStrecke;
        }
    }
}
