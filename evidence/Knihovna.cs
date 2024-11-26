using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence
{
    public class Knihovna
    {
        private List<Pojistenci> vSeznamu = new List<Pojistenci>(); //Uchování klientů co jsou pojištěni

        public void PridatPojistence() //Přidání klienta
        {
            Console.WriteLine();

            string jmeno = "";
            while(string.IsNullOrEmpty(jmeno)) {
                Console.WriteLine("Zadejte jméno:");
                jmeno = Console.ReadLine();
            }

            string prijmeni = "";
            while (string.IsNullOrEmpty(prijmeni))
            {
                Console.WriteLine("Zadejte příjmení:");
                prijmeni = Console.ReadLine();
            }
            Console.WriteLine("Zadejete telefonní číslo:");
            int telefonniCislo = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte věk:");
            int vek = int.Parse(Console.ReadLine());

            Pojistenci clovek = new Pojistenci(jmeno, prijmeni, telefonniCislo, vek); //Přidání klienta
            vSeznamu.Add( clovek );
            
            Console.WriteLine("Data byla uložená. Pokračujte libovolnou klávesou..."); //Úspěšné uložení
            Console.ReadKey();

            Menu.StartMenu(this); //Návrat do menu

            
        }

        public void SeznamPojistenych() //Zobrazení seznamu
        {
            Console.WriteLine();

            if (vSeznamu.Count == 0) //Kontrola seznamu
            {
                Console.WriteLine("Žádní pojištěnci.");
            }
            else
            {
                Console.WriteLine("Seznam pojištěnců:");
            }

            foreach (var clovek in vSeznamu) //Výpis seznamu
            {
                Console.WriteLine("Jméno: " + clovek.Jmeno);

                Console.WriteLine("Příjmení: " + clovek.Prijmeni);

                Console.WriteLine("Telefonní číslo: " + clovek.TelefonniCislo);

                Console.WriteLine("Věk: " + clovek.Vek);
            }
            Menu.StartMenu(this);
        }

        public void vyhledat() //Vyhledání pojištěných klientů
        {
            Console.WriteLine();

            Console.WriteLine("Zadejte jméno a příjmení");
            string jmenoPrijmeni = Console.ReadLine();

            bool nalezen = false;
            
            foreach (var clovek in vSeznamu)
            {
                if (string.Equals($"{clovek.Jmeno} {clovek.Prijmeni}",jmenoPrijmeni))
                {
                    Console.WriteLine("Jméno: " + clovek.Jmeno);

                    Console.WriteLine("Příjmení: " + clovek.Prijmeni);

                    Console.WriteLine("Telefonní číslo: " + clovek.TelefonniCislo);

                    Console.WriteLine("Věk: " + clovek.Vek);

                    nalezen = true;
                }
            }

            if (!nalezen)
            {
                Console.WriteLine("Osoba nebyla nalezena.");
            }
            Menu.StartMenu(this);
        }
        
    }
}
