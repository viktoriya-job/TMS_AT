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
            for (byte i = 0; i < matrix.GetLength(0); i++)
            {
                for (byte j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100);
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }

            //Выведем только главную диагональ матрицы
            Console.WriteLine("\nГлавная диагональ:");
            for (byte diag1_i = 0; diag1_i < matrix.GetLength(0); diag1_i++)
            {
                for (byte diag1_j = 0; diag1_j < matrix.GetLength(1); diag1_j++)
                {
                    if (diag1_i == diag1_j)
                    {
                        Console.Write($"{matrix[diag1_i, diag1_j]}\t");
                    }
                    else
                    {
                        Console.Write("-\t");
                    }
                }
                Console.WriteLine();
            }

            //Выведем только побочную диагональ матрицы
            Console.WriteLine("\nПобочная диагональ:");
            for (byte diag2_i = 0; diag2_i < matrix.GetLength(0); diag2_i++)
            {
                for (byte diag2_j = 0; diag2_j < matrix.GetLength(1); diag2_j++)
                {
                    if (diag2_i == matrix.GetLength(1) - diag2_j-1)
                    {
                        Console.Write($"{matrix[diag2_i, diag2_j]}\t");
                    }
                    else
                    {
                        Console.Write("-\t");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
