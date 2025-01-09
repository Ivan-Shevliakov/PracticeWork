using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    public class PlaceFactory
    {
        public Place CreatePlace((double, int, DateTime) ItemsOfConverter , string TypeOfPressure) 
        {
            Place place = null ;
            if (TypeOfPressure == "Atm")
            {
                place = new PlaceWithPressureInAtm();
            }
            else if (TypeOfPressure == "Pa")
            {
                place = new PlaceWithPressureInPa();
            }
            place.Height = ItemsOfConverter.Item1;
            place.PressureValue = ItemsOfConverter.Item2;
            place.Date = ItemsOfConverter.Item3;
            return place ;
        }
        
    }
}
