using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2. Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
             * Определить сумму максимального и минимального элементов массива.
             */

            float[] array = new float[15];
            float max, min;
            max = min = 0;

            Console.WriteLine("Одномерный массив из 15 чисел в диапазоне [0; 50]:");
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                //Генерация числа в диапазон [0; 50]
                do
                {
                    array[i] = (float)random.Next(0, 51) + (float)random.NextDouble();
                } while (array[i] < 0 || 50 < array[i]);

                //Вывод числа  
                Console.WriteLine("{0:f2}", array[i]);

                //Определение макс и мин
                if (i == 0)
                {
                    max = min = array[i];
                }
                else if (max < array[i])
                {
                    max = array[i];
                }
                else if (min > array[i])
                {
                    min = array[i];
                }
            }

            //Cуммирование макс и мин
            Console.WriteLine("Сумма максимального и минимального элментов массива равна {0:f2}+{1:f2}={2:f2}", max, min, max + min);
            Console.ReadKey();
        }
    }
}
