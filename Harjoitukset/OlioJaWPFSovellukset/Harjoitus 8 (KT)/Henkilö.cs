using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_8__KT_
{
    abstract class Henkilö
    {
        public abstract string Nimi { get; set; }
        public abstract string Työpaikka { get; set; }
        public abstract int Palkka { get; set; }

        private static int Instanssit;

        public Henkilö()
        {
            Instanssit++;
        }
        public static void KuinkaMonta()
        {
            Console.WriteLine("Henkilöitä on " + Instanssit);
        }

        public abstract void Puhu();
    }
}
