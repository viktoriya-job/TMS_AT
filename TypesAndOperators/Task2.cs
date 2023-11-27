using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task2
    {
        public static void RemoveSomeArrayElements()
        {
            Random random = new Random();
            Console.WriteLine("Введите число, которое нужно удалить из следующего массива: ");

            //Выведем исходный массив
            int[] array = new int[20];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(30);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            //Получим искомое число от пользователя
            int num = Convert.ToInt32(Console.ReadLine());

            if (Array.Exists(array, el => el == num))
            {
                //для удаления элементов массив понадобится пересоздать; подсчитаем количество элементов нового массива в переменной lengthArray
                int lengthArray = array.GetLength(0);
                for (int j = lengthArray - 1; j >= 0; j--) // надо заменить на while exists
                {
                    //идем по массиву справа налево, если втретилось искомое число, перезаписываем элемент следующим
                    if (array[j] == num)
                    {
                        lengthArray--;
                        for (int h = j; h < array.GetLength(0) - 1; h++)
                            array[h] = array[h + 1];
                    }
                }

                //могут удалиться все элементы массива
                if (lengthArray == 0)
                    Console.WriteLine("Остался пустой массив");
                else
                {
                    //Создадим новый массив сокращенной длины и перезапишем туда элементы слева направо
                    Console.WriteLine($"Из массива удалено число {num}:");
                    int[] arrayNew = new int[lengthArray];
                    for (int k = 0; k < lengthArray; k++)
                    {
                        arrayNew[k] = array[k];
                        Console.Write($"{array[k]} ");
                    }
                }
            }
            //Введенное число может отсутствовать в массиве
            else
                Console.WriteLine("Данное число отсутствует в массиве");
        }

        public static void RemoveSomeArrayElements2()
        {
            Random random = new Random();
            Console.WriteLine("Введите число, которое нужно удалить из следующего массива: ");

            //Выведем исходный массив
            int[] array = new int[20];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(30);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            //Получим искомое число от пользователя
            int number = Convert.ToInt32(Console.ReadLine());

            if (Array.IndexOf(array, number) == -1)
                Console.WriteLine("Данное число отсутствует в массиве");
            else
            {
                while (Array.Exists(array, element => element == number))
                {
                    int index = Array.IndexOf(array, number);
                    int lenth = array.GetLength(0) - index - 1;

                    Array.Copy(array, index + 1, array, index, lenth);
                    Array.Resize(ref array, array.GetLength(0) - 1);
                }

                //Выведем результат
                if (array.GetLength(0) == 0)
                    Console.WriteLine("Осталась пустая строка");
                else
                {
                    Console.WriteLine($"Из массива удалено число {number}:");
                    foreach (int arrayElement in array)
                        Console.Write($"{arrayElement} ");
                }
            }
        }
    }
}
