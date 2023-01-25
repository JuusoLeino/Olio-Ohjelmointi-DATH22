using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    interface ICanSwim
    {
        int SwimSpeed { get; set; }

        void Swim();
    }
}
