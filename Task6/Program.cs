using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. 
             * Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры 
             * матрица магическим квадратом. Магическим квадратом называется матрица, сумма элементов которой в каждой 
             * строке, в каждом столбце и по каждой диагонали одинакова.
 */
            Console.Write("Введите размерность квадратной матрицы N=");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] array = new double[n, n];
            Boolean check=true;
            double s=0;

            //Заполнение массива, проверка строк
            for (int i = 0; i < n; i++)
            {
                double t = 0;
                Console.WriteLine("Cтрока {0}",i+1);

                for (int j = 0; j < n; j++)
                {
                    array[i,j]=Convert.ToSingle(Console.ReadLine());

                    if (i==0)
                    {
                        s += array[i, j];   // Заполнение требуемой суммы
                    }
                    else
                    {
                        t += array[i, j];   // Заполнение суммы строки
                    }
                }
                // Проверка суммы строки
                if (s != t && i!=0)
                {
                    check = false;
                    //break;
                }
            }

            //Проверка столбцов и диагоналей
            if (!check)
            {

                double d1,d2;
                d1 = d2 = 0;

                for (int j = 0; j < n; j++)
                {

                    double t=0;

                    for (int i = 0; i < n; i++)
                    {
                        
                        t += array[i, j];                         // Заполнение суммы в стоблце
                        if (i==j) { d1 += array[i, j]; }          // Заполнение суммы главной диагонали
                        if ((i + j)==n) { d2 += array[i, j]; }    // Заполнение суммы побочной диагонали
                    }

                    // Проверка суммы столбца
                    if (s != t)
                    {
                        check = false;
                        break;
                    }

                }
                // Проверка суммы в диагоналях
                if (d1!=s || d2!=s)
                {
                    check = false;
                }
            
            }

            // Итоговая проверка
            if (!check)
            {
                Console.WriteLine("Матрица НЕ является Магическим квадратом.");
            }
            else
            {
                Console.WriteLine("Матрица является Магическим квадратом.");
            }

            Console.ReadKey();
        }
    }
}
