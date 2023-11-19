using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndOperators
{
    static class Task7
    {
        public static void SortedArrayOfNames()
        {
            //Создадим и заполним строковый одномерный массив
            string[] arrayOfMyCats = { "Mars", "Bars", "MariyaBarsikovna", "Kseniya", "Lisya", "Mosya", "Kuzya", "Pantera" };

            //Выведем исходный массив
            Console.Write("Just my cats :\t");
            foreach (string element in arrayOfMyCats)
                Console.Write($"{element} ");

            //Отсортируем массив
            Array.Sort(arrayOfMyCats);

            //Выведем обновленный массив
            Console.Write("\nSorted cats) :\t");

            foreach (string element1 in arrayOfMyCats)
                Console.Write($"{element1} ");
            Console.WriteLine();
        }

    }
}
