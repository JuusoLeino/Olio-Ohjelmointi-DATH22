using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Sorsa : Eläin, ICanFly, ICanSwim
    {
        public float WingSize { get; set; }
        public int SwimSpeed { get; set; }

        public Sorsa(string _name, float _wingsize, int _swimspeed)
        {
            Name = _name;
            WingSize = _wingsize;
            SwimSpeed = _swimspeed;
        }

        public void Fly()
        {
            Console.WriteLine("{0} lentää ja siipien koko on {1}", Name, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("Quack");
        }

        public void Swim()
        {
            Console.WriteLine("{0} ui nopeudella {1}", Name, SwimSpeed);
        }
    }
}
