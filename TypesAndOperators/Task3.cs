using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task3
    {
        public static void MaxMinAverageInArray()
        {
            Random random = new Random();

            Console.Write("Введите количество элементов массива: ");
            byte lengthArray = Convert.ToByte(Console.ReadLine());

            //Создадим одномерный массив нужной длины, заполним его случайными числами и выведем
            int[] array = new int[lengthArray];

            for (byte i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(-100, 100);
                Console.Write($"{array[i]} ");
            }

            //Отсортируем массив
            Array.Sort(array);

            //Выведем отсортированный массив
            Console.WriteLine($"\nОтсортированный массив: ");

            foreach (int element in array)
                Console.Write($"{element} ");

            //Выведем искомые величины
            Console.WriteLine($"\nMAX\t: {array[array.GetLength(0) - 1]}");
            Console.WriteLine($"MIN\t: {array[0]}");
            Console.WriteLine($"Average\t: {array[array.GetLength(0) / 2]}");
        }
    }
}
