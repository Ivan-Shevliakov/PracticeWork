using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
           
            Place Place1 = new PlaceWithPressureInPa(converter.DataProcessing("22; 04,02; 1032.2.2"));
            Console.WriteLine(Place1);

            Place Place2 = new PlaceWithPressureInPa(converter.DataProcessing("04,02; 52; 09.09.24"));
            Console.WriteLine(Place2);

            Place Place3 = new PlaceWithPressureInAtm(converter.DataProcessing("1000; 02.02.2002; 1001,1"));
            Console.WriteLine(Place3);

            Place Place4 = new PlaceWithPressureInAtm(converter.DataProcessing("04,02; sada; 09.09.24"));
            Console.WriteLine(Place4);
        }
    }
}
