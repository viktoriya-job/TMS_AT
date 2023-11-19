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
            for (byte i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            //Получим искомое число от пользователя
            int num = Convert.ToInt32(Console.ReadLine());

            //Введенное число может отсутствовать в массиве:
            if (Array.Exists(array, el => el == num) == false)
                Console.WriteLine("Данное число отсутствует в массиве");

            else
            {
                //для удаления элементов массив понадобится пересоздать; подсчитаем количество элементов нового массива в переменной lengthArray
                byte lengthArray = Convert.ToByte(array.GetLength(0));
                for (sbyte j = Convert.ToSByte(lengthArray - 1); j >= 0; j--) // надо заменить на while exists
                {
                    //идем по массиву справа налево, если втретилось искомое число, перезаписываем элемент следующим
                    if (array[j] == num)
                    {
                        lengthArray--;
                        for (sbyte h = j; h < Convert.ToSByte(array.GetLength(0) - 1); h++)
                            array[h] = array[h + 1];
                    }
                }

                //могут удалиться все элементы массива
                if (lengthArray == 0)
                    Console.WriteLine("Остался пустой массив");
                else
                {
                    //Создадим новый массив ссокращенной длины и перезапишем туда элементы слева направо
                    Console.WriteLine($"Из массива удалено число {num}:");
                    int[] arrayNew = new int[lengthArray];
                    for (byte k = 0; k < lengthArray; k++)
                    {
                        arrayNew[k] = array[k];
                        Console.Write($"{array[k]} ");
                    }
                }
            }
        }
    }
}
