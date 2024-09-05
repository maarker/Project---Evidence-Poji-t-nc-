using ProjektEvidencePojistencu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistencu
{
    class UzivatelskeRozhrani
    {   /// <summary>
        /// Žádá po uživateli zadání čísel 1-4. Vrací zadané číslo
        /// </summary>
        /// <returns></returns>
        public int ZadejVolbu()
        {
                            bool volbaValid = false;
                int volba = 0;

                while (!volbaValid)
                {
                    string zvolenaMoznost = Console.ReadKey().KeyChar.ToString();

                    if (int.TryParse(zvolenaMoznost, out volba))
                    {
                        if (volba >= 1 && volba <= 4)
                        {
                            volbaValid = true;
                        }
                        else
                        {
                            Console.WriteLine("\nNeplatná možnost. Zadejte prosím 1 až 4.");
                            volbaValid = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNeplatná možnost. Zadejte prosím 1 až 4.");
                    }
                }
        return volba;
        }
        /// <summary>
        /// Vypíše výzvu pro pokračování libovolnou klávesou
        /// </summary>
        public void Pokracuj()
        {
            Console.WriteLine("\nPokracujte libovolnou klavesou");
            Console.ReadKey();
        }
        /// <summary>
        /// Výzva pro zadání JMÉNA pojištěnce
        /// </summary>
        /// <returns></returns>
        public string ZadejJmenoPojistence()
        {
            Console.WriteLine("\nZadejte jméno pojištěného:");
            string jmeno = Console.ReadLine().ToLower().Trim();
            return jmeno;
        }
        /// <summary>
        /// Výzva pro zadání PŘÍJMENÍ pojištěnce
        /// </summary>
        /// <returns></returns>
        public string ZadejPrijmeniPojistence()
        {
            Console.WriteLine("\nZadejte příjmení pojištěného:");
            string prijmeni = Console.ReadLine().ToLower().Trim();
            return prijmeni;
        }
        /// <summary>
        /// Výzva pro zadání VĚKU pojištěnce
        /// </summary>
        /// <returns></returns>
        public int ZadejVekPojistence()
        {
            int vek;
            Console.WriteLine("\nZadejte věk pojištěného:");
            while(!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("Naplatný výraz, zadejte prosím číslicovou formu věku");
            }
            return vek;
        }
        /// <summary>
        /// Výzva pro zadání TELEFONNÍHO ČÍSLA pojištěnce
        /// </summary>
        /// <returns></returns>
        public string ZadejTelCisloPojistence()
        {
            Console.WriteLine("\nZadejte telefonní číslo:");
            string telCisloString = Console.ReadLine();
            string[] telCisloStrings = telCisloString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            telCisloString = string.Join("", telCisloStrings);
            bool spravneCislo = false;

            while (!spravneCislo)
            {
                foreach (char znak in telCisloString)
                {
                    if (telCisloString.StartsWith('+') || char.IsDigit(znak))
                    {
                        spravneCislo = true;
                    }
                    else
                    {
                        Console.WriteLine("Neplatné číslo. Zadejte prosím správnou formu (např. +420 421 284 754)");
                        telCisloString = Console.ReadLine();
                        telCisloStrings = telCisloString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        telCisloString = string.Join("", telCisloStrings);

                        spravneCislo = false;
                    }
                } 
            }

            return telCisloString;
        }
        /// <summary>
        /// Výzva pro zadání data pojištěnce !!! NEPOUŽITO !!!
        /// </summary>
        /// <returns>string Jméno, string Příjmení, int věk a int telefonní číslo </returns>
        public (string jmeno, string prijmeni, int vek, string telCislo) ZadejDataPojistence()
        {
            string jmeno = "";
            string prijmeni = "";
            int vek = 0;
            string telCislo = "";

            jmeno = ZadejJmenoPojistence();
            prijmeni = ZadejPrijmeniPojistence();
            vek = ZadejVekPojistence();
            telCislo = ZadejTelCisloPojistence();

            return (jmeno, prijmeni, vek, telCislo);
        }

        /// <summary>
        /// Vypíše metodu ToString() pro object Pojistenec
        /// </summary>
        /// <param name="pojistenec"></param>
        public void VypisPojistence(Pojistenec pojistenec)
        {
            Console.WriteLine("\n" + pojistenec);
        }
    }
}
