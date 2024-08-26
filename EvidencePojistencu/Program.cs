using EvidencePojistencu;
using System.Security.Cryptography.X509Certificates;

namespace ProjektEvidencePojistencu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UzivatelskeRozhrani ui = new UzivatelskeRozhrani();
            Databaze databaze = new Databaze();
            Editor editor = new Editor();
            Menu menu = new Menu();

            bool pokracovat = true;
            while (pokracovat)
            {
                Console.Clear();
                menu.VytvorMenu();
                int volba = ui.ZadejVolbu();

                switch (volba)
                {
                    case 1:
                        databaze.PridejPojistence();
                        Console.WriteLine("Data byla ulozena. Pokracujte libovolnou klávesou...");
                        Console.ReadKey();
                        break;
                    case 2:
                        databaze.VypisVsechnyPojistence();
                        ui.Pokracuj();
                        break;
                    case 3:
                        databaze.VyhledejPojistence();
                        ui.Pokracuj();
                        break;
                    case 4:
                        pokracovat = false;
                        break;
                }
            }
        }
    }
}
