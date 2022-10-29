using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Обязательная задача*. Сформировать одномерный массив из 7 элементов. 
             * Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
             */

            Console.WriteLine("Введите 7 чисел");

            float[] array = new float[7];
            float s=0;

            for (int i = 0; i < 7; i++)
            {
                array[i]=Convert.ToSingle(Console.ReadLine());
                s +=array[i];
            }

            Console.WriteLine("Среднее арифметическое элементов массива равно {0}", s / 7);
            Console.ReadKey();
        }
    }
}
