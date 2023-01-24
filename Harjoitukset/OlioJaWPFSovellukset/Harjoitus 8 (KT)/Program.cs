using System;

namespace Harjoitus_8__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ei mitään käryä onko tehtävä suoritus sellane ku pitäs
            Työntekijä työntekijä = new Työntekijä("Pasi", "K-Rauta", 1800, 40);
            Pomo pomo = new Pomo("Jorma", "K-Rauta", 3000, 200, "Lada");
            Henkilö.KuinkaMonta();

            työntekijä.Puhu();
            pomo.Puhu();

        }
    }
}
