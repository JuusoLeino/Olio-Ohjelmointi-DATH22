using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    class Koira : Eläin
    {
        private static int Instanssit;

        public Koira()
        {
            Instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissoja olemassa: " + Instanssit);
        }
        public override void Ääntelee()
        {
            Console.WriteLine("Woof");
        }
    }
}
