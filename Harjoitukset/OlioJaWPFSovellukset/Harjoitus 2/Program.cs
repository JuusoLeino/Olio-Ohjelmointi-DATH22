using System;

namespace Harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //oppilas1 olio Opiskelija luokasta
            Opiskelija oppilas1 = new Opiskelija("Pekka", "AaA123", 0);
            Opiskelija oppilas2 = new Opiskelija("Timo", "ThQ325", 0);

            oppilas1.TulostaData();
            oppilas1.MuokkaaOpintopisteita(15);
            oppilas1.TulostaData();

            oppilas2.TulostaData();
            oppilas2.MuokkaaOpintopisteita(20);
            oppilas2.TulostaData();
        }
    }
}
