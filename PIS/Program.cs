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

            Place Place1 = new Place();
            Place1.DataProcessing("22; 04,02; 1032.2.2");
            Console.WriteLine(Place1.ShowPlaceValues());

            Place Place2 = new Place();
            Place2.DataProcessing("04,02; 52; 09.09.24");
            Console.WriteLine(Place2.ShowPlaceValues());

            Place Place3 = new Place();
            Place3.DataProcessing("1000; 02.02.2002; 1001,1");
            Console.WriteLine(Place3.ShowPlaceValues());

            Place Place4 = new Place();
            Place4.DataProcessing("04,02; sada; 09.09.24");
            Console.WriteLine(Place4.ShowPlaceValues());
        }
    }
}
