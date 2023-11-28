using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Threading.Tasks;
using TypesAndOperators;

namespace TypesAndOperators
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Определить, входит ли заданное число в массив
                2 -  Задача 2: Удалить все вхождения заданного числа из массива
                3 -  Задача 3: Вывести максимальное, минимальное и среднее значение из массива целых чисел
                4 -  Задача 4: Определить, для какого из массивов среднее арифметическое больше
                5 -  Задача 5: Создать массив из четных элементов другого массива
                6 -  Задача 6: Заменить каждый элемент массива с нечетным индексом на ноль
                7 -  Задача 7: Создать и отсортировать массив имен
                8 -  Задача 8: Реализовать алгоритм сортировки пузырьком
                9 -  Задача 9: Перемножить две заданные матрицы
                10 - Задача 10: Вычислить сумму всех элементов двумерного массива
                11 - Задача 11: Вывести диагонали двумерного массива
                12 - Задача 12: Отсортировать каждую строку двумерного целочисленного массива
                """);
            try
            {
                byte task = Convert.ToByte(Console.ReadLine());

                if (task == 0 || task > 12)
                    Console.WriteLine("Вы ввели неправильный номер");
                else
                {
                    switch (task)
                    {
                        case 1: Task1.IsNumberIncludedInArray(); break;
                        case 2: Task2.RemoveSomeArrayElements2(); break;
                        case 3: Task3.MaxMinAverageInArray(); break;
                        case 4: Task4.MathAverageInArrays(); break;
                        case 5: Task5.EvenArrayFromAnother(); break;
                        case 6: Task6.ReplaceOddArrayElementsWithZero(); break;
                        case 7: Task7.SortedArrayOfNames(); break;
                        case 8: Task8.BubbleSort2(); break;
                        case 9: Task9.MultiplyTwoMatrices(); break;
                        case 10: Task10.SumOfAllMatrixElements(); break;
                        case 11: Task11.MatrixDiagonals(); break;
                        case 12: Task12.SortingMatrixRows(); break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка - введено некорректное число.\n{ex}");
            }

            //Lection8_Arrays

            //int[] array1;
            //int n = 4;
            //array1 = new int[n];

            //int[] array = { 1, 9, 3, 6, 5, 8};

            //Console.WriteLine(array[2]);
            //Console.WriteLine(array[array.GetUpperBound(0)]);

            //Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
            //Console.WriteLine("Rank: " + array.Rank);                           // ранк массива
            //Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
            //Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));
            //Console.WriteLine("GetUpperBound(0): " + array.GetLowerBound(0));   // Верхний индекс строк

            //for (int i = 0; i <= array.GetUpperBound(0); i++) {
            //    Console.WriteLine($"Элемент: {array[i]}");
            //}

            //for (int j = 0; j < array.GetLength(0); j++)
            //{
            //    Console.Write($"{array[j]} ");
            //}
            //foreach (int k in array) {
            //        Console.Write($"{k} ");
            //    }
        }
    }
}