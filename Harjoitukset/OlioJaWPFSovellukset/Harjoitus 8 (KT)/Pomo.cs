using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_8__KT_
{
    class Pomo : Henkilö
    {
        public override string Nimi { get; set; }
        public override string Työpaikka { get; set; }
        public override int Palkka { get; set; }
        public int Bonus { get; set; }
        public string Auto { get; set; }

        public Pomo(string _nimi, string _työpaikka, int _palkka, int _bonus, string _auto)
        {
            Nimi = _nimi;
            Työpaikka = _työpaikka;
            Palkka = _palkka;
            Bonus = _bonus;
            Auto = _auto;
        }

        public override void Puhu()
        {
            Console.WriteLine("\nPomo tiedot:");
            Console.WriteLine("Nimi -- " + Nimi);
            Console.WriteLine("Työpaikka -- " + Työpaikka);
            Console.WriteLine("Palkka -- " + Palkka);
            Console.WriteLine("Bonus -- " + Bonus);
            Console.WriteLine("Auto -- " + Auto);
        }
    }
}
