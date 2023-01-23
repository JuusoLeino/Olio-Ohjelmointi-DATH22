using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    class Kissa : Eläin
    {
        private static int Instanssit;

        public Kissa()
        {
            Instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissoja olemassa: " + Instanssit);
        }
        public override void Ääntelee()
        {
            Console.WriteLine("Meow");
        }
    }
}
