using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse
{
    class Magazyn
    {
        private string nazwa { get; set; } = "Sklepowy";
        private int pojemnosc { get; set; } = 1000_000;
        protected bool CzyDostepny = true;
        public static bool Otwarty = true;
        public void ZmienNazwe(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public void ZmienPojemnosc(int pojemnosc)
        {
            this.pojemnosc = pojemnosc;
        }
    }
}
