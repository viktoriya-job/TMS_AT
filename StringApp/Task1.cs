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
        public static string ReplaceSomeSubstringAndRemoveAllDigits(string inputString, string replacementSubstring, string targetSubstring)
        {
            //создадим экземпляр StringBuilder, передав ему строку с уже выполненной заменой
            //надо понимать, что строки типа te213st не будут преобразованы в testing, так как по условию задачи сначала - замена, потом - удаление цифр
            var stringBuilder = new StringBuilder(inputString.Replace(replacementSubstring, targetSubstring));

            //в цикле удалим все цифры
            int i = 0;

            while (i < stringBuilder.Length)
            {
                if (Char.IsDigit(stringBuilder[i]))
                {
                    stringBuilder.Remove(i, 1);
                    continue;
                }
                i++;
            }

            if (stringBuilder.Length > 0)
                return stringBuilder.ToString();
            else
                return "Осталась пустая строка";
        }
    }
}
