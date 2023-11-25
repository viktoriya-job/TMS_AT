using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    internal class Task2
    {
        public static void CollectStringFromArray(string[] array)
        {
            Console.WriteLine("{1}{0}{1}", String.Join("\" \"", array), "\"");
        }
    }
}
