using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    internal class Task4
    {
        public static string RemoveAndInsertSomeSubstrings(string sourceString, string? stringToRemove, string? stringToInsertAtBegin, string? stringToInsertAtEnd, string? stringToReplaceAtEnd)
        {
            if (String.IsNullOrEmpty(sourceString))
                return "Исходная строка не может быть пустой";
            else
            {
                string stringResult = sourceString;

                //Удалим подстроку из начала исходной строки, если подстрока не пустая и содержится в исходной строке
                //Если подстрока не содержится в исходной строке, сразу завершаем обработку и возвращаем ошибку
                if (!String.IsNullOrEmpty(stringToRemove) && !sourceString.Contains(stringToRemove))
                    return "Указанная подстрока не может быть удалена, так как не содержится в исходной строке";

                else if (!String.IsNullOrEmpty(stringToRemove) && sourceString.Contains(stringToRemove))
                    stringResult = sourceString.Substring(sourceString.IndexOf(stringToRemove) + stringToRemove.Length);

                //Если параметр не пустой, вставим подстроку в начало
                if (!String.IsNullOrEmpty(stringToInsertAtBegin))
                    stringResult = stringResult.Insert(0, stringToInsertAtBegin);

                //Если параметр не пустой, вставим подстроку в конец
                if (!String.IsNullOrEmpty(stringToInsertAtEnd))
                    stringResult = stringResult.Insert(stringResult.Length, stringToInsertAtEnd);

                //Если параметр не пустой и результирующая строка пришла не пустая, заменим последний символ на подстроку
                if (!String.IsNullOrEmpty(stringToReplaceAtEnd) && !String.IsNullOrEmpty(stringResult))
                    stringResult = stringResult.Remove(stringResult.Length - 1, 1).Insert(stringResult.Length - 1, stringToReplaceAtEnd);

                //Если же результирующая строка пришла пустая, вернем ошибку
                else if (!String.IsNullOrEmpty(stringToReplaceAtEnd) && String.IsNullOrEmpty(stringResult))
                    return "Невозможно заменить последний элемент пустой строки";

                return stringResult;
            }
        }
    }
}
