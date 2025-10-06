using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    public abstract class Place
    {
        public double Height { get; set; } 
        public int PressureValue { get; set; } 
        public DateTime Date { get; set; } 
        public string GetPlaceValues()
        {
                return ($"Высота:{Height} м \nДавление : {PressureValue} \nДата: {Date.ToString("d")}\n");           
        }
        public void SetPlaceValues(string placeString)
        {
            ConverterToPlaceValues converter = new ConverterToPlaceValues();
            (double, int, DateTime) values = converter.ParseInDataSet(placeString);
            PressureValue = values.Item2;
            Height = values.Item1;
            Date = values.Item3;
        }
    }
}
