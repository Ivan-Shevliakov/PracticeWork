using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    public class Converter
    {
        public (double, int, DateTime) DataProcessing(string line)
        {
            string[] strings = LineSpliting(line);
            double Height = Double.MinValue;
            int PressureValue = int.MinValue;
            DateTime Date = DateTime.MinValue;
            if (strings.Length != 3) { return (Height, PressureValue, Date); }
            foreach (string s in strings)
                if (int.TryParse(s, out int pressureValue)) 
                {
                    PressureValue = pressureValue; 
                }
                else if (s.Contains(",") & double.TryParse(s, out double height)) 
                { 
                    Height = height; 
                }
                else if (DateTime.TryParse(s, out DateTime date) & s.Split('.').Length == 3) 
                { 
                    Date = date; 
                }
            return (Height, PressureValue, Date);
        }
        private string[] LineSpliting(string line)
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
            return strings;
        }
    } 

}
