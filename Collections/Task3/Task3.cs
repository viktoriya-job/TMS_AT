using Collections.Helper;
using System.Collections.Generic;

namespace Collections
{
    internal class Task3
    {
        public static void Run()
        {
            Console.WriteLine("Исходная коллекция");
            List<int> list = new List<int>{ 1, 2, 3, 4, 4, 5};
            PrintHelper.PrintCollection(list);

            Console.WriteLine("\nКоллекция без повторяющихся элементов");
            HashSet<int> set = new HashSet<int>(list);
            PrintHelper.PrintCollection(set);
        }
    }
}
