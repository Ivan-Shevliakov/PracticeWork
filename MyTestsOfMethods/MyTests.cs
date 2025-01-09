
using System;

namespace MyTestsOfMethods
{
    public class MyTests
    {
        [Fact]
        public void DataProcessingTestWithCorrectDataSeparatedByCommaOrBySpace()
        {
            // ������ ���� ��������� �� �������� ��������� ���������� ������, ���������� ����� ������ ��� ����� � �������  
            // �������� ������� ����� ����� ������ "22; 04,02; 1032.2.2", ��������, ��� ������� ����� ����� ������  (double , int, DateTime) ������ (4.02, 22, 02.02.1032) 
            string x = "22; 04,02; 1032.2.2";
            (double, int, DateTime) expected = (4.02, 22, new DateTime(1032, 02, 02));
            PIS.Converter converter = new PIS.Converter();
            (double, int, DateTime) actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // �������� ������� ����� ����� ������ "22 04,02 1032.2.2" �������� ��� ������� ����� ����� ������  (double , int, DateTime) ������ (4.02, 22, 02.02.1032)
            x = "22 04,02 1032.2.2";
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DataProcessingTestWithCorrectDataButInADifferentOrder()
        {
            // ������ ���� ��������� �� �������� ��������� ���������� ������, �� � ��������� ������� �� ������� ������
            // �������� ������� ����� ����� ������ "22 04,02 1032.2.2", ��������, ��� ������� ����� ����� ������  (double , int, DateTime) ������ (4.02, 22, 02.02.1032) 
            string x = "22 04,02 1032.2.2";
            (double, int, DateTime) expected = (4.02, 22, new DateTime(1032, 02, 02));
            PIS.Converter converter = new PIS.Converter();
            (double, int, DateTime) actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // �������� ������� ����� ����� ������ "04,02 22 1032.2.2", ��������, ��� ������� ����� ����� ������  (double , int, DateTime) ������ (4.02, 22, 02.02.1032)
            x = "04,02 22 1032.2.2";
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DataProcessingTestWithAnEmptyLine()
        {
            // ������ ���� ��������� �� �������� ��������� ������ ������
            // �������� ������� ����� ����� ������ ������ "" �������� ��� ������� ����� ����� ������  (double , int, DateTime) ������ (double.MinValue, int.MinValue, DateTime.MinValue) 
            string x = "";
            (double, int, DateTime) expected = (double.MinValue, int.MinValue, DateTime.MinValue);
            PIS.Converter converter = new PIS.Converter();
            (double, int, DateTime) actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);


        }
        [Fact]
        public void DataProcessingTestWithVariousIncorrectData()
        {
            // ��������� ���� ��������� �� �������� ��������� ������������ ������, � ��������� ���������
            // �������� ������� ����� ����� ������ ������ "11 11,1 �", �������� ��� ������� ����� ����� ������,  (double , int, DateTime) ������ (11.1, 11, DateTime.MinValue) 
            string x = "11 11,1 �";
            (double, int, DateTime) expected = (11.1, 11, DateTime.MinValue);
            PIS.Converter converter = new PIS.Converter();
            (double, int, DateTime) actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // �������� ������� ����� ����� ������ "11 � 1032.2.2", ��������, ��� ������� ����� ����� ������  (double , int, DateTime) ������ (Double.MinValue, 11, 02.02.1032)
            x = "11 � 1032.2.2";
            expected = (Double.MinValue, 11, new DateTime(1032, 02, 02));
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // �������� ������� ����� ����� ������ "c 11,1 1032.2.2", ��������, ��� ������� ����� ����� ������  (double , int, DateTime) ������ (11.1, int.MinValue, 02.02.1032)
            x = "c 11,1 1032.2.2";
            expected = (11.1, int.MinValue, new DateTime(1032, 02, 02));
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // �������� ������� ����� ����� ������ "sddaaaadadsczcasd", ��������, ��� ������� ����� ����� ������  (double , int, DateTime) ������ (double.MinValue, int.MinValue, DateTime.MinValue) 
            x = "sddaaaadadsczcasd";
            expected = (double.MinValue, int.MinValue, DateTime.MinValue);
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DataProcessingWithMoreOrLessInputDataThanNeeded()
        {
            // ����� ���� ��������� �� �������� ��������� ������ � ������� ��� ������� ����������� ������� ������
            // �������� ������� ����� ����� ������ ������ "1 1" �������� ��� ������� ����� ����� ������  (double , int, DateTime) ������ (double.MinValue, int.MinValue, DateTime.MinValue) 
            string x = "1 1";
            (double, int, DateTime) expected = (double.MinValue, int.MinValue, DateTime.MinValue);
            PIS.Converter converter = new PIS.Converter();
            (double, int, DateTime) actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
            // �������� ������� ����� ����� ������ ������ "1 1,2 2010.12.12 23" �������� ��� ������� ����� ����� ������  (double , int, DateTime) ������ (double.MinValue, int.MinValue, DateTime.MinValue) 
            x = "1 1,2 2010.12.12 23";
            expected = (double.MinValue, int.MinValue, DateTime.MinValue);
            actual = converter.DataProcessing(x);
            Assert.Equal(expected, actual);
        }

    }
}