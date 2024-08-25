using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEvidencePojistencu
{
    internal class Pojistenec
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public int TelCislo { get; private set; }

        public Pojistenec(string jmeno, string prijmeni, int vek, int telCislo)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Vek = vek;
            this.TelCislo = telCislo;
        }

        public override string ToString()
        {
            return $"{Jmeno}\t{Prijmeni}\t{Vek}\t{TelCislo}";
        }
    }
}
