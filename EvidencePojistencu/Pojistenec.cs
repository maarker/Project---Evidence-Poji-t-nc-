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
            string JmenoPrvniPismeno = Jmeno.Substring(0, 1).ToUpper();
            string JmenoZbytek = Jmeno.Substring(1, Jmeno.Length - 1);
            Jmeno = JmenoPrvniPismeno + JmenoZbytek;

            string PrijmeniPrvniPismeno = Prijmeni.Substring(0, 1).ToUpper();
            string PrijmeniZbytek = Prijmeni.Substring(1, Prijmeni.Length - 1);
            Prijmeni = PrijmeniPrvniPismeno + PrijmeniZbytek;

            return $"{Jmeno}\t{Prijmeni}\t{Vek}\t{TelCislo}";
        }
    }
}
