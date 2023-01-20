using System;

namespace Harjoitus_3__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan kiuas1 olio Kiuas luokasta
            Kiuas kiuas1 = new Kiuas(false, 0, "kuiva");

            //datan tulostus ja muuttaminen
            kiuas1.TulostaData();
            kiuas1.MuutaArvoja(true, 15, "hieman kostea");
            kiuas1.TulostaData();
            kiuas1.MuutaArvoja(true, 20, "enemmän kostea");
            kiuas1.TulostaData();
            kiuas1.MuutaArvoja(false, -35, "kuiva");
            kiuas1.TulostaData();

        }
    }
}
