using System;

namespace Harjoitus_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int uusiKerros;
            Hissi hissi = new Hissi();
            Console.WriteLine("Olet nyt hississä pääset ulos syöttämällä \"poistu\"");

            while (true)
            {
                Console.WriteLine("Anna hissi kerros (1-6) > ");
                string luettuArvo = Console.ReadLine();

                if (luettuArvo.Equals("poistu"))
                {
                    break;
                }

                bool result = int.TryParse(luettuArvo, out uusiKerros);

                if (result)
                {
                    hissi.HissiKerros = uusiKerros;
                }
            }
        }
    }
}
