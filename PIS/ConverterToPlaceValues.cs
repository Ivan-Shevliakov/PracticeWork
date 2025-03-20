using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS
{
    public class ConverterToPlaceValues
    {
        public (double, int, DateTime) ParseInDataSet(string line)
        {
            double DoubleValue = new double();
            int IntValue = new int();
            DateTime DateTimeValue = new DateTime();
            string[] strings = LineSpliting(line);
            foreach (string s in strings)
            {
                if (s.Contains(",") && double.TryParse(s, out double doubleStr))
                {
                    DoubleValue = doubleStr;
                }
                else if (int.TryParse(s, out int IntStr))
                {
                    IntValue=IntStr;
                }
                else if (s.Split('.').Length == 3 && DateTime.TryParse(s, out DateTime DateTimeStr))
                {
                    DateTimeValue = DateTimeStr;
                }
                else 
                {
                    throw new IncorrectDataException("Некорректные данные: значения введены неправильно");
                }
            }
                return (DoubleValue, IntValue, DateTimeValue);
           
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
            if (strings.Length != 3)
            {
                throw new IncorrectDataException("Некорректные данные: в строке не три значения");
            }
            return strings;
        }
        
    } 

}
