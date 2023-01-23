using System;

namespace Harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Eläin.KuinkaMonta();

            Kissa kissa = new Kissa();
            Koira koira = new Koira();

            koira.Nimi = "Joni";
            kissa.Nimi = "Kaapo";

            Console.WriteLine(kissa.Nimi);
            Console.WriteLine(koira.Nimi);
            Eläin.KuinkaMonta();
            Kissa.KuinkaMonta();
            Koira.KuinkaMonta();
        }
    }
}
