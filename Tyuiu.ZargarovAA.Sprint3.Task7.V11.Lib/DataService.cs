using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZargarovAA.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        // Метод вычисляет и возвращает массив значений на основе заданного диапазона [startValue, stopValue].
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Объявляем массив для хранения вычисленных значений.
            double[] valueArray;

            // Вычисляем длину массива на основе заданного диапазона.
            int len = (stopValue - startValue) + 1;

            // Инициализируем массив вычисленной длиной.
            valueArray = new double[len];

            // Переменные для хранения текущих значений x и y в цикле.
            double y;
            int count = 0; // Счетчик для отслеживания индекса массива.

            // Проходим по каждому значению x в указанном диапазоне.
            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверяем, равно ли x 1.
                if (x == 1)
                {
                    // Если x равно 1, устанавливаем y в 0.
                    y = 0;
                    // Присваиваем вычисленное значение y массиву.
                    valueArray[count] = y;
                    // Увеличиваем счетчик.
                    count++;
                }
                else
                {
                    // Если x не равно 1, вычисляем y на основе заданной формулы.
                    y = Math.Round(Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x, 2);
                    // Присваиваем вычисленное значение y массиву.
                    valueArray[count] = y;
                    // Увеличиваем счетчик.
                    count++;
                }
            }

            // Возвращаем массив вычисленных значений.
            return valueArray;
        }
    }
}
