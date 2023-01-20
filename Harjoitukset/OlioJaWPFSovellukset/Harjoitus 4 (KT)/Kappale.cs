using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_4__KT_
{
    class Kappale
    {
        public string Nimi { get; set; }
        public string Pituus { get; set; }

        public Kappale(string _nimi, string _pituus)
        {
            Nimi = _nimi;
            Pituus = _pituus;
        }
        public void ToString()
        {
            Console.WriteLine(" -- Nimi: " + Nimi + " - "  + Pituus);
        }
    }
}
