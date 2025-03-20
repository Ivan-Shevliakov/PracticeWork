
using PIS;
using System;

namespace MyTestsOfMethods
{
    public class MyTests
    {
        [Fact]
        public void DataProcessingTestWithCorrectDataSeparatedByCommaOrBySpace()
        {
            string x = "22; 04,02; 1032.2.2";
            (double, int, DateTime) expected = (4.02, 22, new DateTime(1032, 02, 02));
            PIS.ConverterToPlaceValues converter = new PIS.ConverterToPlaceValues();
            (double, int, DateTime) actual = converter.ParseInDataSet(x);
            Assert.Equal(expected, actual);
            x = "22 04,02 1032.2.2";
            actual = converter.ParseInDataSet(x);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DataProcessingTestWithCorrectDataButInADifferentOrder()
        {
            string x = "22 04,02 1032.2.2";
            (double, int, DateTime) expected = (4.02, 22, new DateTime(1032, 02, 02));
            PIS.ConverterToPlaceValues converter = new PIS.ConverterToPlaceValues();
            (double, int, DateTime) actual = converter.ParseInDataSet(x);
            Assert.Equal(expected, actual);
            x = "04,02 22 1032.2.2";
            actual = converter.ParseInDataSet(x);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DataProcessingTestWithAnEmptyLine()
        {
            string x = "";
            PIS.ConverterToPlaceValues converter = new PIS.ConverterToPlaceValues();
            Assert.Throws<IncorrectDataException>(() => converter.ParseInDataSet(x));
        }
        [Fact]
        public void DataProcessingTestWithVariousIncorrectData()
        {
            string x = "11 11,1 ñ";
            PIS.ConverterToPlaceValues converter = new PIS.ConverterToPlaceValues();
            Assert.Throws<IncorrectDataException>(() => converter.ParseInDataSet(x));
            x = "11 ñ 1032.2.2";
            Assert.Throws<IncorrectDataException>(() => converter.ParseInDataSet(x));
            x = "c 11,1 1032.2.2";
            Assert.Throws<IncorrectDataException>(() => converter.ParseInDataSet(x));
        }
        [Fact]
        public void DataProcessingWithMoreOrLessInputDataThanNeeded()
        {
            string x = "1 1,2";
            PIS.ConverterToPlaceValues converter = new PIS.ConverterToPlaceValues();
            Assert.Throws<IncorrectDataException>(() => converter.ParseInDataSet(x));
        }

    }
}