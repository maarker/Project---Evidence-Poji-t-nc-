using EvidencePojistencu;
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
        public string CeleJmeno { get { return Jmeno + " " + Prijmeni; }}
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
            string JmenoSVelkym = Jmeno.Length == 0 ? "" : Char.ToUpper(Jmeno[0]) + Jmeno.Substring(1);
            string PrijmeniSVelkym = Prijmeni.Length == 0 ? "" : Char.ToUpper(Prijmeni[0]) + Prijmeni.Substring(1);
            return $"{JmenoSVelkym}\t{PrijmeniSVelkym}\t{Vek}\t{TelCislo}";
        }
    }
}
