using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEvidencePojistencu
{
    internal class HUD
    {

        public HUD()
        {
        }

        Databaze databaze = new Databaze();

        public void VytvorHUD()
        {
            bool pokracovat = true;
            while (pokracovat)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Evidence pojistených");
                Console.WriteLine("-----------------------------");

                Console.WriteLine("\nVyberte si akci:");
                Console.WriteLine("1 - Pridat nového pojisteného");
                Console.WriteLine("2 - Vypsat vsechny pojistené");
                Console.WriteLine("3 - Vyhledat pojisteného");
                Console.WriteLine("4 - Konec");

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

                switch (volba)
                {
                    case 1:
                        Console.WriteLine("\n");
                        databaze.PridejPojistence();
                        Console.WriteLine("\nPokracujte libovolnou klavesou");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        databaze.VypisVsechny();
                        Console.WriteLine("\nPokracujte libovolnou klavesou");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        databaze.VyhledejPojistence();
                        Console.WriteLine("\nPokracujte libovolnou klavesou");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n");
                        pokracovat = false;
                        break;

                }
            }
        }

    }
}
