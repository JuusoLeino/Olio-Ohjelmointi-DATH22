using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_4__KT_
{
    class Album
    {
        private string Artisti { get; set; }
        private string Nimi { get; set; }
        private string Genre { get; set; }
        private string Hinta { get; set; }

        Kappale song1 = new Kappale("Ace Of Spades","2:45");
        Kappale song2 = new Kappale("Live To Win", "3:36");
        Kappale song3 = new Kappale("Fire, Fire", "2:40");
        Kappale song4 = new Kappale("Dance", "2:37");
        Kappale song5 = new Kappale("The Hammer", "2:44");

        public Album(string _artisti, string _nimi, string _genre, string _hinta)
        {
            Artisti = _artisti;
            Nimi = _nimi;
            Genre = _genre;
            Hinta = _hinta;
        }

        public void TulostaTidot()
        {
            Console.WriteLine("Album:");
            Console.WriteLine("--Artisti: " + Artisti);
            Console.WriteLine("--Nimi: " + Nimi);
            Console.WriteLine("--Genre: " + Genre);
            Console.WriteLine("--Hinta: " + Hinta);
            Console.WriteLine("Songs:");
            song1.ToString();
            song2.ToString();
            song3.ToString();
            song4.ToString();
            song5.ToString();
        }

        
    }
}
