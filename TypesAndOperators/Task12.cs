using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task12
    {
        public static void SortingMatrixRows()
        {
            Random random = new Random();
            int[,] matrix = new int[4, 5];

            // Заполним матрицу случайными числами и выведем ее
            Console.WriteLine("Исходная матрица: ");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100);
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            //Отсортируем элементы в каждой строке матрицы и выведем результат
            //Для сортировки элементов каждой строки создадим временный массив
            Console.WriteLine("Матрица с отсортированными элемантами в строках:");

            int[] temp = new int[5];

            for (int sort_i = 0; sort_i < matrix.GetLength(0); sort_i++)
            {
                for (int sort_j = 0; sort_j < matrix.GetLength(1); sort_j++)
                    temp[sort_j] = matrix[sort_i, sort_j];

                Array.Sort(temp);

                //В одном цикле перезапишем элементы строки матрицы элементами отсортированного массива и выведем строку матрицы
                for (int sort_h = 0; sort_h < matrix.GetLength(1); sort_h++)
                {
                    matrix[sort_i, sort_h] = temp[sort_h];
                    Console.Write($"{matrix[sort_i, sort_h]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
