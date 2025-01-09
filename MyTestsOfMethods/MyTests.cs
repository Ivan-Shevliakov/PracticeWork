
using System;

namespace MyTestsOfMethods
{
    public class MyTests
    {
        [Fact]
        public void DataProcessingTest1()
        {
            // Первый тест направлен на проверку обработки корреткных данных, записанных через пробел и точки с запятой  
            // вводными данными теста будет строка "22; 04,02; 1032.2.2", ожидание, что выводом будет набор данных  (double , int, DateTime) равный (4.02, 22, 02.02.1032) 
            string x = "22; 04,02; 1032.2.2";
            (double, int, DateTime) expected = (4.02, 22, new DateTime(1032, 02, 02));
            PIS.Converter converter = new PIS.Converter();
            (double, int, DateTime) actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // вводными данными теста будет строка "22 04,02 1032.2.2" ожидание что выводом будет набор данных  (double , int, DateTime) равный (4.02, 22, 02.02.1032)
            x = "22 04,02 1032.2.2";
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DataProcessingTest2()
        {
            // Второй тест направлен на проверку обработки корреткных данных, но в различном порядке во входной строке
            // вводными данными теста будет строка "22 04,02 1032.2.2", ожидание, что выводом будет набор данных  (double , int, DateTime) равный (4.02, 22, 02.02.1032) 
            string x = "22 04,02 1032.2.2";
            (double, int, DateTime) expected = (4.02, 22, new DateTime(1032, 02, 02));
            PIS.Converter converter = new PIS.Converter();
            (double, int, DateTime) actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // вводными данными теста будет строка "04,02 22 1032.2.2", ожидание, что выводом будет набор данных  (double , int, DateTime) равный (4.02, 22, 02.02.1032)
            x = "04,02 22 1032.2.2";
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DataProcessingTest3()
        {
            // Третий тест направлен на проверку обработки пустой строки, но в различном порядке во входной строке
            // вводными данными теста будет пустая строка "" ожидание что выводом будет набор данных  (double , int, DateTime) равный (double.MinValue, int.MinValue, DateTime.MinValue) 
            string x = "";
            (double, int, DateTime) expected = (double.MinValue, int.MinValue, DateTime.MinValue);
            PIS.Converter converter = new PIS.Converter();
            (double, int, DateTime) actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);


        }
        [Fact]
        public void DataProcessingTest4()
        {
            // Четвертый тест направлен на проверку обработки некорреткных данных, в различных вариациях
            // вводными данными теста будет пустая строка "11 11,1 с", ожидание что выводом будет набор данных,  (double , int, DateTime) равный (11.1, 11, DateTime.MinValue) 
            string x = "11 11,1 с";
            (double, int, DateTime) expected = (11.1, 11, DateTime.MinValue);
            PIS.Converter converter = new PIS.Converter();
            (double, int, DateTime) actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // вводными данными теста будет строка "11 с 1032.2.2", ожидание, что выводом будет набор данных  (double , int, DateTime) равный (Double.MinValue, 11, 02.02.1032)
            x = "11 с 1032.2.2";
            expected = (Double.MinValue, 11, new DateTime(1032, 02, 02));
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // вводными данными теста будет строка "c 11,1 1032.2.2", ожидание, что выводом будет набор данных  (double , int, DateTime) равный (11.1, int.MinValue, 02.02.1032)
            x = "c 11,1 1032.2.2";
            expected = (11.1, int.MinValue, new DateTime(1032, 02, 02));
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // вводными данными теста будет строка "sddaaaadadsczcasd", ожидание, что выводом будет набор данных  (double , int, DateTime) равный (double.MinValue, int.MinValue, DateTime.MinValue) 
            x = "sddaaaadadsczcasd";
            expected = (double.MinValue, int.MinValue, DateTime.MinValue);
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
        }

    }
}