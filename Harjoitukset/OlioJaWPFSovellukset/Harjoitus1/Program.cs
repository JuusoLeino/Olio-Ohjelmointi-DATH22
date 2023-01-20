using System;

namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            //auto olio Ajoneuvo -luokasta
            Ajoneuvo auto = new Ajoneuvo();

            //Alustetaan olion auto tiedot;
            auto.Nimi = "Lada";
            auto.Nopeus = 55;
            auto.Renkaat = 3;

            //tulostetaan auto olion tiedot
            auto.TulostaData();

            //alustetaan ajoneuvonTiedot muuttuja auto olion tiedoilla jotta ne voi tulostaa
            string ajoneuvonTiedot = auto.ToString();

            //tulostetaan auto olion tiedot eri tavalla
            Console.WriteLine(ajoneuvonTiedot);

            //mopo olio Ajoneuvo luokasta
            Ajoneuvo mopo = new Ajoneuvo();

            //Alustetaan mopo olion tiedot
            mopo.Nimi = "Kevari";
            mopo.Nopeus = 80;
            mopo.Renkaat = 2;

            //tulostetaan mopo olion tiedot kahdella eri tavalla
            mopo.TulostaData();
            Console.WriteLine(mopo.ToString());
        }
    }
}
