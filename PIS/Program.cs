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
            ConverterToPlaceValues converter = new ConverterToPlaceValues();
            PlaceFactory factory = new PlaceFactory();
            Place place ;
            
            foreach (var line in linesOfDataFile) 
            {
                try
                {
 
                    if (line.Contains("Atm"))
                    {
                        place = new PlaceWithPressureInAtm();
                        place.SetPlaceValues(line.Replace("Atm", ""));
                        Console.WriteLine(place);
                    }
                    else if (line.Contains("Pa"))
                    {
                        place = new PlaceWithPressureInAtm();
                        place.SetPlaceValues(line.Replace("Pa", ""));
                        Console.WriteLine(place);
                    }
                    else { throw new IncorrectDataException("Некорректные данные: в строке нет единицы измерения давления"); }
                }
                catch(Exception e) 
                {
                    Console.WriteLine("Строка: "+ (Array.IndexOf(linesOfDataFile,line)+1));
                    Console.WriteLine(e.Message + "\n");

                } 
                
                
                
            }
            
            

        }
    }
}
