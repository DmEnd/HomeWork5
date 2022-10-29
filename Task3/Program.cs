using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3. Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. 
             * Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
             */
            float[] array = new float[10];
            
            Console.WriteLine("Одномерный массив из 10 чисел в диапазоне [-50; 50]:");
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                //Генерация числа в диапазон [-50; 50]
                do
                {
                    array[i] = ((random.Next(-1, 1) == 0) ? 1 : -1) * ((float)random.Next(0, 51) + (float)random.NextDouble());
                } while (array[i] < -50 || 50 < array[i]);

                //Вывод числа  
                Console.WriteLine("{0,6:f2}", array[i]);
            }


            //Сортировка
            for (int i = 0; i < 9; i++)
            {
                //По возрастанию первые 5 элементов
                if (i<5)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (array[i] > array[j])
                        {
                            float s = array[i];
                            array[i] = array[j];
                            array[j] = s;
                        }
                    }
                }
                //По убыванию оставшиеся элементы
                else
                {
                    for (int j = i + 1; j < 10; j++)
                    {
                        if (array[i] < array[j])
                        {
                            float s = array[i];
                            array[i] = array[j];
                            array[j] = s;
                        }
                    }
                }   
            }

            //Вывод отсортированного массива
            Console.WriteLine("Отсориторованный массив");

            foreach (var item in array)
            {
                Console.WriteLine("{0,6:f2}", item);
            }

            Console.ReadKey();
        }
    }
}
