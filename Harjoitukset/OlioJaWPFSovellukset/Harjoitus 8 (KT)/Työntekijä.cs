using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_8__KT_
{
    class Työntekijä : Henkilö
    {
        public override string Nimi { get; set; }
        public override string Työpaikka { get; set; }
        public override int Palkka { get; set; }
        public int TyöTunnit { get; set; }

        public Työntekijä(string _nimi, string _työpaikka, int _palkka, int _työtunnit)
        {
            Nimi = _nimi;
            Työpaikka = _työpaikka;
            Palkka = _palkka;
            TyöTunnit = _työtunnit;
        }
        public override void Puhu()
        {
            Console.WriteLine("\nTyöntekiä tiedot: ");
            Console.WriteLine("Nimi -- " + Nimi);
            Console.WriteLine("Työpaikka -- " + Työpaikka);
            Console.WriteLine("Palkka -- " + Palkka);
            Console.WriteLine("Työtunnit -- " + TyöTunnit);
        }
    }
}
