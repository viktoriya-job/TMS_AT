using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringApp
{
    internal class Task6
    {
        public static string NormalizeString(string inputString)
        {
            if (inputString.Length <= 100)
                return new Regex(@"\s+").Replace(inputString, " ");
            else
                return $"Строка содержит больше 100 символов. Длина строки {inputString.Length}";
        }
    }
}
