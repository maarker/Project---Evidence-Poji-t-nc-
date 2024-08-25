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

        public void PridejPojistence()
        {
            string jmeno = "";
            string prijmeni = "";
            int telCislo = 0;
            int vek = 0;

            Console.WriteLine("Zadejte jméno pojisteného:");
            jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte príjmení:");
            prijmeni = Console.ReadLine();

            Console.WriteLine("Zadejte vek:");
            vek = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte telefonní císlo:");
            string telCisloString = Console.ReadLine();
            string[] telCisloStrings = telCisloString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            telCisloString = string.Join("", telCisloStrings);
            telCislo = int.Parse(telCisloString.Trim());

            Pojistenec pojistenec = new Pojistenec(jmeno, prijmeni, vek, telCislo);

            pojistenci.Add(pojistenec);
            Console.WriteLine("Data byla ulozena. Pokracujte libovolnou klávesou...");
        }

        public void VypisVsechny()
        {
            foreach (Pojistenec pojistenec in pojistenci)
            {
                Console.WriteLine(pojistenec);
            }
        }


        public void VyhledejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojisteného:");
            string hledaniJmena = Console.ReadLine();
            Console.WriteLine("Zadejte prijmení:");
            string hledaniPrijmeni = Console.ReadLine();


            List<Pojistenec> nalezeniPojistenci = new List<Pojistenec>();
            bool nalezen = false;

            foreach (Pojistenec pojistenec in pojistenci)
            {
                if (pojistenec.Jmeno.Equals(hledaniJmena) && pojistenec.Prijmeni.Equals(hledaniPrijmeni))
                {
                    nalezeniPojistenci.Add(pojistenec);
                    nalezen = true;
                }
            }
            if (nalezen)
            {
                foreach (Pojistenec nalezenyPojistenec in nalezeniPojistenci)
                {
                    Console.WriteLine($"\n{nalezenyPojistenec}");
                }
            }
            else
            {
                Console.WriteLine("\nŽádný záznam na toto jméno nenalezen.");
            }
        }
    }
}
