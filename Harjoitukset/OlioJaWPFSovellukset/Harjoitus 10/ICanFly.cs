using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    interface ICanFly
    {
        float WingSize { get; set; }

        void Fly();
    }
}
