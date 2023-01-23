using System;

namespace Harjoitus_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0.6f;
            float b = 2.3f;

            float summa = Laskin.Summa(a, b);
            float erotus = Laskin.Erotus(a, b);
            float tulo = Laskin.Tulos(a, b);
            float osamäärä = Laskin.Osamäärä(a, b);

            Console.WriteLine(summa);
            Console.WriteLine(erotus);
            Console.WriteLine(tulo);
            Console.WriteLine(osamäärä);
        }
    }
}
