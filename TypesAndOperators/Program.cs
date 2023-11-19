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

            Console.WriteLine("Выберите задачу:" +
                "\n\t1 -\tЗадача 1: Определить, входит ли заданное число в массив" +
                "\n\t2 -\tЗадача 2: Удалить все вхождения заданного числа из массива" +
                "\n\t3 -\tЗадача 3: Вывести максимальное, минимальное и среднее значение из массива целых чисел" +
                "\n\t4 -\tЗадача 4: Определить, для какого из массивов среднее арифметическое больше" +
                "\n\t5 -\tЗадача 5: Создать массив из четных элементов другого массива" +
                "\n\t6 -\tЗадача 6: Заменить каждый элемент массива с нечетным индексом на ноль" +
                "\n\t7 -\tЗадача 7: Создать и отсортировать массив имен" +
                "\n\t8 -\tЗадача 8: Реализовать алгоритм сортировки пузырьком" +
                "\n\t9 -\tЗадача 9: Перемножить две заданные матрицы" +
                "\n\t10 -\tЗадача 10: Вычислить сумму всех элементов двумерного массива" +
                "\n\t11 -\tЗадача 11: Вывести диагонали двумерного массива" +
                "\n\t12 -\tЗадача 12: Отсортировать каждую строку двумерного целочисленного массива");
            byte task = Convert.ToByte(Console.ReadLine());

            if (task == 0 || task > 12)
                Console.WriteLine($"Вы ввели неправильный номер");

            else
            {
                switch (task)
                {
                    case 1: Task1.IsNumberIncludedInArray(); break;
                    case 2: Task2.RemoveSomeArrayElements(); break;
                    case 3: Task3.MaxMinAverageInArray(); break;
                    case 4: Task4.MathAverageInArrays(); break;
                    case 5: Task5.EvenArrayFromAnother(); break;
                    case 6: Task6.ReplaceOddArrayElementsWithZero(); break;
                    case 7: Task7.SortedArrayOfNames(); break;
                    case 8: Task8.BubbleSort(); break;
                }
            }

        }
    }
}