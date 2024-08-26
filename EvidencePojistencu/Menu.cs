using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistencu
{
    internal class Menu
    {
        /// <summary>
        /// Vytvoří základní menu pro volbu další akce
        /// </summary>
        public void VytvorMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------\n" +
                                "     Evidence pojistených\n" +
                                "------------------------------\n" +

                                "\nVyberte si akci:\n" +
                                "1 - Pridat nového pojisteného\n" +
                                "2 - Vypsat vsechny pojistené\n" +
                                "3 - Vyhledat pojisteného\n" +
                                "4 - Konec\n");
        }
    }
}
