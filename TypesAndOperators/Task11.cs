using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task11
    {
        public static void MatrixDiagonals()
        {
            Random random = new Random();

            int[,] matrix = new int[5, 5];

            //Заполним матрицу случайными числами и выведем ее
            Console.WriteLine("Матрица: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100);
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }

            //Выведем только главную диагональ матрицы
            Console.WriteLine("\nГлавная диагональ:");
            for (int diagonal1_i = 0; diagonal1_i < matrix.GetLength(0); diagonal1_i++)
            {
                for (int diagonal1_j = 0; diagonal1_j < matrix.GetLength(1); diagonal1_j++)
                    if (diagonal1_i == diagonal1_j)
                        Console.Write($"{matrix[diagonal1_i, diagonal1_j]}\t");
                    else
                        Console.Write("-\t");
                Console.WriteLine();
            }

            //Выведем только побочную диагональ матрицы
            Console.WriteLine("\nПобочная диагональ:");
            for (byte diagonal2_i = 0; diagonal2_i < matrix.GetLength(0); diagonal2_i++)
            {
                for (byte diagonal2_j = 0; diagonal2_j < matrix.GetLength(1); diagonal2_j++)
                    if (diagonal2_i == matrix.GetLength(1) - diagonal2_j-1)
                        Console.Write($"{matrix[diagonal2_i, diagonal2_j]}\t");
                    else
                        Console.Write("-\t");
                Console.WriteLine();
            }
        }
    }
}
