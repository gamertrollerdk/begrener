using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begrener
{
    using System;

    class KlasseB
    {
        public KlasseB()
        {
           
        }

        public double KonverterKnotTilKmT(double knob)
        {
            return knob * 1.852;
        }

        public double KonverterKmTTilKnot(double kmT)
        {
            return kmT / 1.852;
        }
    }
}
