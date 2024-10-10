using EvidencePojistencu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEvidencePojistencu
{
    internal class Databaze
    {
        public List<Pojistenec> pojistenci = new List<Pojistenec>();
        UzivatelskeRozhrani ui = new UzivatelskeRozhrani();
        /// <summary>
        /// Po zadání potřebných parametrů pro vytvoření instance Pojistenec, tuto instanci přidá do databáze
        /// </summary>
        public void PridejPojistence()
        {
            Pojistenec pojistenec = new Pojistenec(ui.ZadejJmenoPojistence(),
                                                   ui.ZadejPrijmeniPojistence(),
                                                    ui.ZadejTelCisloPojistence(),
                                                    ui.ZadejVekPojistence());
            pojistenci.Add(pojistenec);
        }

        /// <summary>
        /// Vypíše všechny zapsané pojištěnce
        /// </summary>
        public void VypisVsechnyPojistence()
        {
            foreach (Pojistenec pojistenec in pojistenci)
            {
                ui.VypisPojistence(pojistenec);
            }
        }
        /// <summary>
        /// Po zadání jména a příjmení hledaného pojištěnce vrátí záznamy podle výsledků
        /// </summary>
        public void VyhledejPojistence()
        {
            string hledaniJmena = ui.ZadejJmenoPojistence();
            string hledaniPrijmeni = ui.ZadejPrijmeniPojistence();


            List<Pojistenec> nalezeniPojistenci = new List<Pojistenec>();
            bool nalezen = false;

            foreach (Pojistenec pojistenec in pojistenci)
            {
                if (pojistenec.Jmeno.ToLower().Equals(hledaniJmena.ToLower()) && pojistenec.Prijmeni.ToLower().Equals(hledaniPrijmeni.ToLower()))
                {
                    nalezeniPojistenci.Add(pojistenec);
                    nalezen = true;
                }
            }
            if (nalezen)
            {
                foreach (Pojistenec nalezenyPojistenec in nalezeniPojistenci)
                {
                    ui.VypisPojistence(nalezenyPojistenec);
                }
            }
            else
            {
                Console.WriteLine("\nŽádný záznam na toto jméno nenalezen.");
            }
        }
    }
}
