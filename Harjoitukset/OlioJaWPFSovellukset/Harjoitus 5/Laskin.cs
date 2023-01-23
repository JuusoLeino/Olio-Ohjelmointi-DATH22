using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_5
{
    static class Laskin
    {
        public static float Summa(float a, float b)
        {
            float summa = a + b;
            return summa;
        }

        public static float Erotus(float a, float b)
        {
            float erotus = a - b;
            return erotus;
        }

        public static float Tulos(float a, float b)
        {
            float tulo = a * b;
            return tulo;
        }

        public static float Osamäärä(float a, float b)
        {
            float osamäärä = a / b;
            return osamäärä;
        }
    }
}
