using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    public abstract class Place
    {
        
        public Place((double, int, DateTime) ItemsOfConverter) 
        {
            Height = ItemsOfConverter.Item1;
            PressureValue = ItemsOfConverter.Item2;
            Date = ItemsOfConverter.Item3;

        }

        public double Height { get; set; } = -10000;
        public int PressureValue { get; set; } = -1;
        public DateTime Date { get; set; }
        public string GetPlaceValues()
        {
            if (PressureValue == -1 | Height == -10000 | Date.Year == 1)
            {
                return ("\nДанные неккоректны!!!\n");
            }
            else
            {
                return ($"\nВысота:{Height} м \nДавление : {PressureValue} \nДата: {Date.ToString("d")}\n");
            }
        }
        
        
    
}
}
