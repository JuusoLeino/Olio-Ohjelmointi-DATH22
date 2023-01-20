using System;

namespace Harjoitus_4__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album1 = new Album("motörhead", "Ace of Spades", "Heavy Metal", "En tiedä :)");

            album1.TulostaTidot();
        }
    }
}
