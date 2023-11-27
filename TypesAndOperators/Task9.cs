using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task9
    {
        public static void MultiplyTwoMatrices()
        {
            //Создадим исходные двумерные массивы - матрицы
            int[,] matrix1 = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
            int[,] matrix2 = { { 1, 2, 3 }, { 1, 1, 1 }, { 0, 0, 0 }, { 2, 1, 0 } };
            int[,] resultMatrix = new int[3,3];

            //Организуем перемножение двух матриц
            for (int matr1 = 0; matr1 < matrix1.GetLength(0); matr1++)
                for (int matr2 = 0; matr2 < matrix2.GetLength(1); matr2++)
                    for (int inter = 0; inter < matrix1.GetLength(1); inter++)
                        resultMatrix[matr1,matr2] += matrix1[matr1, inter] * matrix2[inter,matr2];

            //Выведем исходные матрицы и результат их умножения
            Console.WriteLine("\nМатрица 1: ");
            for (int i1 = 0; i1 < matrix1.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < matrix1.GetLength(1); j1++)
                    Console.Write($"{matrix1[i1, j1]} ");
                Console.WriteLine();
            }

            Console.WriteLine("\nМатрица 2: ");
            for (int i2 = 0; i2 < matrix2.GetLength(0); i2++)
            {
                for (int j2 = 0; j2 < matrix2.GetLength(1); j2++)
                    Console.Write($"{matrix2[i2, j2]} ");
                Console.WriteLine();
            }

            Console.WriteLine("\nРезультат умножения: ");
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    Console.Write($"{resultMatrix[i,j]} ");
                Console.WriteLine();
            }
        }
    }
}
