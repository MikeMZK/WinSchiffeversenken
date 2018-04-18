using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSchiffeversenken
{
    class Schiff
    {
        public int Laenge { get; private set; }
        public int XKoord { get; private set; }
        public int YKoord { get; private set; }
        public bool Kaputt { get; private set; }
        public bool Horizontal { get; private set; }

        public Schiff(int Laenge, int XKoord, int YKoord, bool Horizontal)
        {
            this.Laenge = Laenge;
            this.XKoord = XKoord;
            this.YKoord = YKoord;
            this.Kaputt = false;
            this.Horizontal = Horizontal;
        }



    }
}
