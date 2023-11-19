using System.Threading.Tasks;
using TypesAndOperators;

internal class Program
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
            }
        }

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