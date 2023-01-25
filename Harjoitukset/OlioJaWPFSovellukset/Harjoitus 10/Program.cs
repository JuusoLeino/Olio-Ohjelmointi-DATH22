using System;

namespace Harjoitus_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Varis varis = new Varis("Varis", 85);

            varis.Fly();
            varis.MakeASound();

            Kala silakka = new Kala("Silakka", 25, "What up");

            silakka.Swim();
            silakka.MakeASound();

            Sorsa sorsa = new Sorsa("Sorsa", 90, 15);

            sorsa.Fly();
            sorsa.Swim();
            sorsa.MakeASound();
        }
    }
}
