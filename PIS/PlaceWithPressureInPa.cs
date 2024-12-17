using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    public class PlaceWithPressureInPa: Place
    {
        public PlaceWithPressureInPa((double, int, DateTime) ItemsOfConvertere) : base(ItemsOfConvertere) { }
        public string typeOfValuePressure = "Па";
        public override string ToString()
        {
            return $"Место с давлением в {typeOfValuePressure} \n" + GetPlaceValues();
        }
    }
}
