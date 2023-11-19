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
            int[,] matrix1 = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
            int[,] matrix2 = { { 1, 2, 3 }, { 1, 1, 1 }, { 0, 0, 0 }, { 2, 1, 0 } };
            int[,] resultMatrix = { { 0,0,0},{0,0,0 },{0,0,0 } };

            //Перемножение двух матриц
            for (byte matr1 = 0; matr1 < matrix1.GetLength(0); matr1++)
                for (byte matr2 = 0; matr2 < matrix2.GetLength(1); matr2++)
                    for (byte inter = 0; inter < matrix1.GetLength(1); inter++)
                        resultMatrix[matr1,matr2] += matrix1[matr1, inter] * matrix2[inter,matr2];

            //Вывод исходных матриц и результата умножения
            Console.WriteLine("\nМатрица 1: ");
            for (byte i1 = 0; i1 < matrix1.GetLength(0); i1++)
            {
                for (byte j1 = 0; j1 < matrix1.GetLength(1); j1++)
                    Console.Write($"{matrix1[i1, j1]} ");
                Console.WriteLine();
            }

            Console.WriteLine("\nМатрица 2: ");
            for (byte i2 = 0; i2 < matrix2.GetLength(0); i2++)
            {
                for (byte j2 = 0; j2 < matrix2.GetLength(1); j2++)
                    Console.Write($"{matrix2[i2, j2]} ");
                Console.WriteLine();
            }

            Console.WriteLine("\nРезультат умножения: ");
            for (byte i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (byte j = 0; j < resultMatrix.GetLength(1); j++)
                    Console.Write($"{resultMatrix[i,j]} ");
                Console.WriteLine();
            }
        }
    }
}
