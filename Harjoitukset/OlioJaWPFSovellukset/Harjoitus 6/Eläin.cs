using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    class Eläin
    {
        public virtual string Nimi { get; set; }

        private static int Instanssit;

        public Eläin()
        {
            Instanssit++;
        }
        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä olemassa: " + Instanssit);
        }

        public virtual void Ääntelee()
        {
            Console.WriteLine("Eläin ääntelee");
        }
    }
}
