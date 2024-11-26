using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence
{
    public class Pojistenci
    {
        public string Jmeno {  get; set; } //Uchování jména
        public string Prijmeni { get; set; } //Uchování příjmení
        public int TelefonniCislo { get; set; } //Uchování tel. čísla
        public int Vek {  get; set; } //Uchování věku

        public Pojistenci(string jmeno, string prijmeni, int telefonniCislo, int vek) //Kontruktor pro vytvoření třídy
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonniCislo = telefonniCislo;
            Vek = vek;
        }
    }
}
