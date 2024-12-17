using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    public class PlaceWithPressureInAtm: Place
    {
        public PlaceWithPressureInAtm((double, int, DateTime) ItemsOfConverter) : base(ItemsOfConverter) { }
        public string typeOfValuePressure = "Атм";
        public override string ToString()
        {
            return $"Место с давлением в {typeOfValuePressure} \n" + GetPlaceValues();
        }
    }
}
