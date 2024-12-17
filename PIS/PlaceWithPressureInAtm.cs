using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    public class PlaceWithPressureInAtm: Place
    {
        public override string ToString()
        {
            return "Место с давлением в атм \n" + GetPlaceValues();
        }
    }
}
