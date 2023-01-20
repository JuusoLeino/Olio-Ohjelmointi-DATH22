using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus1
{
    class Ajoneuvo
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvon tiedot:");
            Console.WriteLine("-- Nimi: " + Nimi);
            Console.WriteLine("-- Nopeus: " + Nopeus);
            Console.WriteLine("-- Renkaat: " + Renkaat);
        }

        public string ToString()
        {
            string merkkijono = "Ajoneuvon tiedot: Nimi: " + Nimi + ". Nopeus: " + Nopeus + "km/h. Renkaat: " + Renkaat + " kpl.";
            return merkkijono;
        }
    }
}
