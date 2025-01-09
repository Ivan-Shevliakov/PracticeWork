using System;
using System.IO;
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
            string[] linesOfDataFile = File.ReadAllLines("Входные Данные.txt");
            Converter converter = new Converter();
            PlaceFactory factory = new PlaceFactory();
            Place place ;
            foreach (var line in linesOfDataFile) 
            {
                if (line.Contains("-Atm"))
                    {
                    place = factory.CreatePlace(converter.DataProcessing(line.Replace("-Atm", "")), "Atm"); 
                    Console.WriteLine(place);
                    }
                else if (line.Contains("-Pa"))
                {
                    place = factory.CreatePlace(converter.DataProcessing(line.Replace("-Pa", "")), "Pa");
                    Console.WriteLine(place);
                }
                else 
                {
                    Console.WriteLine("В строке не указан тип значения давления \n");
                }
            }
            

        }
    }
}
