using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence
{
    public class Pojistenci
    {
        public string Jmeno {  get; set; }
        public string Prijmeni { get; set; }
        public int TelefonniCislo { get; set; }
        public int Vek {  get; set; }

        public Pojistenci(string jmeno, string prijmeni, int telefonniCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonniCislo = telefonniCislo;
            Vek = vek;
        }
    }
}
