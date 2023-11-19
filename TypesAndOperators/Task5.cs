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
            byte lengthArray = Convert.ToByte(Console.ReadLine());
            while (lengthArray <= 5 || lengthArray > 10)
            {
                Console.Write($"Число {lengthArray} не входит в требуемый интервал (5, 10]. Пожалуйста, повторите ввод:  ");
                lengthArray = Convert.ToByte(Console.ReadLine());
            }
            Console.Write("Массив1: ");
            int[] array = new int[lengthArray];

            for (byte i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(100);
                Console.Write($"{array[i]} ");
            }

            byte numberOfEvenElements = 0;
            foreach (int element in array)
            {
                if (element % 2 == 0)
                    numberOfEvenElements++;
                if (numberOfEvenElements > 0) break;
            }

            if (numberOfEvenElements == 0)
                Console.WriteLine("\nВ массиве 1 нет четных элементов");

            else
            {
                Console.Write("\nМассив2: ");
                foreach (int element2 in array)
                {
                    if (element2 % 2 == 0)
                        Console.Write($"{element2} ");
                }
            }
        }
    }
}
