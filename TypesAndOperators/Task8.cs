using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task8
    {
        public static void BubbleSort()
        {
            Random random = new Random();

            //Получим от пользователя число элементов будущего масссива
            Console.Write("Введите число элементов массива: ");
            byte lengthArray = Convert.ToByte(Console.ReadLine());

            //Создадим массив, заполним его случайными элементами и выведем
            int[] array = new int[lengthArray];

            Console.Write("Исходный массив:\t");
            for (int i = 0; i < lengthArray; i++)
            {
                array[i] = random.Next(-100, 100);
                Console.Write($"{array[i]} ");
            }

            //Органируем пузырьковую сортировку - соседние элементы меняются местами по возрастанию,
            //в каждой итерации "становится на место" последний из обрабатываемых элементов 
            while (lengthArray > 0)
            {
                for (byte j = 0; j < lengthArray - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                lengthArray--;
            }

            //Выведем полученный массив
            Console.Write("\nОтсортированный массив:\t");
            foreach (int element in array)
                Console.Write($"{element} ");

        }
    }
}
