using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence
{
    public class Menu
    {
        public static void StartMenu(Knihovna knihovna)
        {

            Menu.moznost();
            
            string moznost = Console.ReadLine();

            switch (moznost)
            {
                case "1":
                    knihovna.PridatPojistence();
                    break;
                
                case "2":
                    knihovna.SeznamPojistenych();
                    break;
                case "3":
                    knihovna.vyhledat();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
            Console.Clear();
        }
        public static void moznost()
        {
            Console.WriteLine("Správa pojištění");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec\n");
        }
    }
}
