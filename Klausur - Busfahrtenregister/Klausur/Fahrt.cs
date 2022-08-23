using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur
{
    class Fahrt
    {
        long id;
        int fahrtnummer;
        string stadt;
        string bundesland;
        public float entfernung;
        public Fahrt(long id, int fahrtnummer, string stadt, string bundesland, float entfernung)
        {
            this.id = id;
            this.fahrtnummer = fahrtnummer;
            this.stadt = stadt;
            this.bundesland = bundesland;
            this.entfernung = entfernung;
            
            
        }
        public override string ToString()
        {
            return fahrtnummer+ " " + stadt + " " + bundesland + " " + entfernung + "km";
        }
    }
}
