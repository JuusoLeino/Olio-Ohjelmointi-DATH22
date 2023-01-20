using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_3__KT_
{
    class Kiuas
    {
        private bool OnOff { get; set; }
        private int Lämpötila { get; set; }
        private string Kosteus { get; set; }

        //luodaan konstruktori
        public Kiuas (bool _onoff, int _lämpötila, string _kosteus)
        {
            OnOff = _onoff;
            Lämpötila = _lämpötila;
            Kosteus = _kosteus;
        }

        //metodi jolla data tulostetaan
        public void TulostaData()
        {
            Console.WriteLine();
            Console.WriteLine("Kiuaksen tiedot:");
            if(OnOff == true)
            {
                Console.WriteLine("-- Kiuas on päällä");
            }
            else if (OnOff == false)
            {
                Console.WriteLine("-- Kiuas on pois päältä");
            }
            Console.WriteLine("-- Lämpötila: " + Lämpötila);
            Console.WriteLine("-- Kosteus: " + Kosteus);
            Console.WriteLine();

        }

        //metodi jolla muuttaa arvoja
        public void MuutaArvoja(bool b, int i, string s)
        {
            OnOff = b;
            Lämpötila += i;
            Kosteus = s;
        }
    }
}
