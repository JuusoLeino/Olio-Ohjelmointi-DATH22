using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_7
{
    class Hissi
    {
        private int hissikerros;

        public int HissiKerros
        {
          get => hissikerros;
          set
          {
            if (value < 1)
            {
                Console.WriteLine("Virheellinen luku. Kerrokset menevät 1-6. Anna uusi kerros: ");
                value = 1;
            }
            else if (value > 6)
            {
                Console.WriteLine("Virheellinen luku. Kerrokset menevät 1-6. Anna uusi kerros: ");
                value = 1;
            }


            Console.WriteLine("\nHissi on kerroksessa: " + value);
            hissikerros = value;
          }
        }
    }
}
