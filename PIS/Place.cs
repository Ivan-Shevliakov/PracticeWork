using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    public abstract class Place
    {
        public Place() { }

        public double Height { get; set; } = -10000;
        public int PressureValue { get; set; } = -1;
        public DateTime Date { get; set; }
        public string GetPlaceValues()
        {
            if (PressureValue == -1 | Height == -10000 | Date.Year == 1)
            {
                return ("\nДанные неккоректно!!!\n");
            }
            else
            {
                return ($"\nВысота:{Height} м \nДавление : {PressureValue} \nДата: {Date.ToString("d")}\n");
            }
        }
        public void DataProcessing(string line)
        {
            string[] strings;
            if (line.Contains(";"))
            {
                strings = line.Split(';');
            }
            else
            {
                strings = line.Split(' ');
            }
            foreach (string s in strings)
            {
                if (int.TryParse(s, out int pressureValue)) { PressureValue = pressureValue; }
                else if (s.Contains(",") & double.TryParse(s, out double height)) { Height = height; }
                else if (DateTime.TryParse(s, out DateTime date) & s.Split('.').Length == 3) { Date = date; }
            }
        }
        
    
}
}
