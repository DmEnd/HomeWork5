using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Сформировать одномерный массив из 20 случайных чисел в диапазоне[-50; 50]. Определить количество  
             * нечетных положительных элементов, стоящих на четных местах.
            */
            int n=0;

            float[] array = new float [20];

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                //Генерация целого чисела в диапазон [-50; 50]
                array[i] = random.Next(-51, 51);

                if (array[i] % 2 > 0 && array[i]>0 && (i+1) % 2 == 0)
                {
                    n++;
                }

                Console.WriteLine(array[i]) ;
            }

            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах={0}.",n);
            Console.ReadKey();
        }
    }
}
