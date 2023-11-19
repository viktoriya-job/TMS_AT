using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task6
    {
        public static void ReplaceOddArrayElementsWithZero()
        {
            Random random = new Random();

            int[] array = new int[10];

            Console.WriteLine("Исходный массив:\t");
            for (byte i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(100);
                Console.Write($"{array[i]}\t");
            }

            for (byte j = 0; j < array.GetLength(0); j += 2)
                array[j] = 0;

            Console.WriteLine("\nОбновленный массив:\t");
            foreach (int element in array)
                Console.Write($"{element}\t");
        }
    }
}
