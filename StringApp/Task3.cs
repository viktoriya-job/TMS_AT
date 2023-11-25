using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    internal class Task3
    {
        public static void SplitString(string inputString,string separator)
        {
            if (inputString.Contains(separator))
            {
                Console.WriteLine($"Исходная строка: {inputString}");
                Console.Write($"Результат разделения сепаратором {separator}: ");
                string[] newStrings = inputString.Split(separator);
                foreach (string str in newStrings)
                    Console.Write($"{str} ");
            }
            else
                Console.WriteLine("Заданный разделитель отсутствует в исходной строке");
        }
    }
}
