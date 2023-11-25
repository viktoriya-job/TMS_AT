using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringApp
{
    internal class Task7
    {
        public static string SortWordsInString(string inputString)
        {
            if (inputString.Length > 100)
                return $"Строка содержит больше 100 символов. Длина строки {inputString.Length}";
            else
            {
                string[] words = new Regex(@"\s+").Replace(inputString, " ").Split(" ");
                if (words.Length > 20)
                    return $"Количество слов в строке превышает 20. Всего слов: {words.Length}";

                else
                    foreach (string word in words)
                        if (word.Length > 10)
                            return $"Длина слова {word} = {word.Length} превышает 10.";
                Array.Sort(words);
                return String.Join(" ", words);
            }
        }
    }
}
