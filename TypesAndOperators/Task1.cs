using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task1
    {
        public static void IsNumberIncludedInArray()
        {
            Random random = new Random();

            Console.WriteLine("Введите число, вхождение которого в следующем массиве нужно проверить: \n");

            //Создадим массив, заполним его случайными элементами и выведем
            int[] array = new int[10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            int num = Convert.ToInt32(Console.ReadLine());

            if (Array.Exists(array, element => element == num))
                Console.WriteLine($"Число {num} входит в массив");
            else
                Console.WriteLine($"Число {num} не входит в массив");
        }
    }
}

