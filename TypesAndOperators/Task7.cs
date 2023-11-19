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
            string[] arrayOfMyCats = { "Mars", "Bars", "MariyaBarsikovna", "Kseniya", "Lisya", "Mosya", "Kuzya", "Pantera" };

            Console.Write("Just my cats :\t");
            foreach (string element in arrayOfMyCats)
                Console.Write($"{element} ");

            Console.Write("\nSorted cats) :\t");

            Array.Sort(arrayOfMyCats);

            foreach (string element1 in arrayOfMyCats)
                Console.Write($"{element1} ");
            Console.WriteLine();
        }

    }
}
