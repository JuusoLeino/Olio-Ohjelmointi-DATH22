using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Varis : Eläin, ICanFly
    {
        public float WingSize { get; set; }

        public Varis(string _name, float _wingsize)
        {
            Name = _name;
            WingSize = _wingsize;
        }

        public void Fly()
        {
            Console.WriteLine("{0} lentää ja sen siipien koko on {1}", Name, WingSize); 
        }

        public override void MakeASound()
        {
            Console.WriteLine("Kakaaw");
        }
    }
}
