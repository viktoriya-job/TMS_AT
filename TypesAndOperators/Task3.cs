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

            int[] array = new int[lengthArray];

            for (byte i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(-100, 100);
                Console.Write($"{array[i]} ");
            }

            Array.Sort(array);
            Console.WriteLine($"\nОтсортированный массив: ");

            foreach (int element in array)
                Console.Write($"{element} ");

            Console.WriteLine($"\nMAX\t: {array[array.GetLength(0) - 1]}");
            Console.WriteLine($"MIN\t: {array[0]}");
            Console.WriteLine($"Average\t: {array[array.GetLength(0) / 2]}");
        }
    }
}
