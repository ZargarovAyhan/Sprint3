using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZargarovAA.Sprint3.Task7.V11.Lib;

namespace Tyuiu.ZargarovAA.Sprint3.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Создаем экземпляр DataService для тестирования.
            DataService ds = new DataService();

            // Устанавливаем значения начала и конца диапазона.
            int startValue = -5;
            int stopValue = 5;

            // Вычисляем ожидаемую длину массива значений.
            int len = stopValue - startValue + 1;

            // Инициализируем ожидаемый массив значений.
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            // Устанавливаем значения в ожидаемом массиве.
            valueWaitArray[0] = 20.36;
            valueWaitArray[1] = 15.42;
            valueWaitArray[2] = 10.99;
            valueWaitArray[3] = 7.43;
            valueWaitArray[4] = 4.33;
            valueWaitArray[5] = 1;
            valueWaitArray[6] = 0;
            valueWaitArray[7] = -8.87;
            valueWaitArray[8] = -13.03;
            valueWaitArray[9] = -16.53;
            valueWaitArray[10] = -19.60;

            // Инициализируем массив для хранения результатов.
            double[] res;
            res = new double[len];

            // Получаем массив значений от DataService и присваиваем его результатам.
            res = ds.GetMassFunction(startValue, stopValue);

            // Проверяем, соответствуют ли фактические результаты ожидаемым.
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
