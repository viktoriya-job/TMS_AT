using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task4
    {
        public static void MathAverageInArrays()
        {
            Random random = new Random();

            //Создадим два одномерных массива и две переменных для подсчета сумм элементов в каждом массиве
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int sumArray1, sumArray2;
            sumArray1 = sumArray2 = 0;

            //Заполним массивы случайными элементами
            for (int i = 0; i < 5; i++)
            {
                array1[i] = random.Next(-100, 100);
                array2[i] = random.Next(-100, 100);
            }

            //Выведем массивы
            Console.Write("\nМассив 1:\t");
            foreach (int element1 in array1)
            {
                Console.Write($"{element1}\t");
                sumArray1 += element1;
            }

            Console.Write("\nМассив 2:\t");
            foreach (int element2 in array2)
            {
                Console.Write($"{element2}\t");
                sumArray2 += element2;
            }

            //Выведем значения среднего арифметического для каждого массива
            Console.WriteLine($"\nСреднее арифметическое для массива1 = {Convert.ToSingle(sumArray1) / array1.GetLength(0)}");
            Console.WriteLine($"Среднее арифметическое для массива2 = {Convert.ToSingle(sumArray2) / array2.GetLength(0)}");

            //Выведем, для какого из массивов значение среднего арифметического оказалось больше
            if (Convert.ToSingle(sumArray1) / array1.GetLength(0) == Convert.ToSingle(sumArray2) / array2.GetLength(0))
                Console.WriteLine("Значения среднего арифметического равны для массивов 1 и 2");
            else if (Convert.ToSingle(sumArray1) / array1.GetLength(0) > Convert.ToSingle(sumArray2) / array2.GetLength(0))
                Console.WriteLine("Для массива 1 значение среднего арифметического больше, чем для массива 2");
            else
                Console.WriteLine("Для массива 2 значение среднего арифметического больше, чем для массива 1");
        }
    }
}
