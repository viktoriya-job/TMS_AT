using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task10
    {
        public static void SumOfAllMatrixElements()
        {
            Random random = new Random();

            int[,] matrix = new int[4, 5];

            //заполним матрицу случайными числами
            for (byte i = 0; i < matrix.GetLength(0); i++)
                for (byte j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(100);

            int summ = 0;
            foreach (int element in matrix)
                summ += element;

            //Выведем получившуюся матрицу и итоговую сумму всех элементов матрицы
            Console.WriteLine("Матрица: ");
            for (byte resI = 0; resI < matrix.GetLength(0); resI++)
            {
                for (byte resJ = 0; resJ < matrix.GetLength(1); resJ++)
                    Console.Write($"{matrix[resI, resJ]} "); ;
                Console.WriteLine();
            }
            Console.WriteLine($"\nСумма всех элементов матрицы: {summ}");
        }
    }
}
