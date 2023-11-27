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

            //Заполним матрицу случайными элементами и выведем ее
            Console.WriteLine("Матрица: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            //Вычислим сумму всех элементов матрицы и выведем ее
            int summ = 0;
            foreach (int element in matrix)
                summ += element;

            Console.WriteLine($"\nСумма всех элементов матрицы: {summ}");
        }
    }
}
