using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task5
    {
        public static void EvenArrayFromAnother()
        {
            Random random = new Random();

            Console.Write("Введите количество элементов массива из интервала (5, 10]: ");
            int lengthArray = Convert.ToInt32(Console.ReadLine());

            //Дождемся, пока пользователь введет нужное число
            while (lengthArray <= 5 || lengthArray > 10)
            {
                Console.Write($"Число {lengthArray} не входит в требуемый интервал (5, 10]. Пожалуйста, повторите ввод:  ");
                lengthArray = Convert.ToInt32(Console.ReadLine());
            }

            //Заполним массив случайными числами и выведем его
            Console.WriteLine("Исходный массив: ");
            int[] array = new int[lengthArray];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(100);
                Console.Write($"{array[i]} ");
            }

            //Выясним, сколько в массиве четных элементов
            int numberOfEvenElements = 0;
            foreach (int element in array)
                if (element % 2 == 0)
                    numberOfEvenElements++;

            //В массиве может не быть четных элементов
            if (numberOfEvenElements == 0)
                Console.WriteLine("\nВ исходном массиве нет четных элементов");
            else
            {
                //Создадим новый массив и запишем в него только четные элементы
                int[] arrayNew = new int[numberOfEvenElements];

                int temp = 0;
                foreach (int element2 in array)
                    if (element2 % 2 == 0)
                    {
                        arrayNew[temp] = element2;
                        temp++;
                    }

                //Выведем полученный массив
                Console.WriteLine("\nПолученный массив четных элементов: ");
                foreach (int element3 in arrayNew)
                    Console.Write($"{element3} ");
            }
        }
    }
}
