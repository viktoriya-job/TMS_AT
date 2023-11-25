using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringApp
{
    internal class Task1
    {
        public static string ReplaceSomesubstringAndRemoveAllDigits(string inputString, string replacementSubstring, string targetSubstring)
        {
            var stringBuilder = new StringBuilder(inputString.Replace(replacementSubstring, targetSubstring));
            for (int i = 0; i < stringBuilder.Length; i++)
                if (Char.IsDigit(stringBuilder[i]))
                {
                    stringBuilder.Remove(i, 1);
                    i--; // при удалении элемента пропускаем символ - вернем счетчик, иначе не обработаются идущие подряд символы 
                }

            if (stringBuilder.Length > 0)
                return stringBuilder.ToString();
            else
                return "Осталась пустая строка";
        }
    }
}
