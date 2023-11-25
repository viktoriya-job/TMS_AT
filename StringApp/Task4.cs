using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    internal class Task4
    {
        public static string ReplaceWordInString(string inputString, string substringToRemove, string substringToInsert1, string substringToInsert2, string? replacementLastPart)
        {
            if (inputString.Contains(substringToRemove))
            {
                return inputString.Substring(inputString.LastIndexOf(substringToRemove) + substringToRemove.Length).Insert(0, substringToInsert1).Insert(inputString.Length - substringToRemove.Length + substringToInsert1.Length, substringToInsert2.Remove(substringToInsert2.Length-1).Insert(substringToInsert2.Length-1,replacementLastPart));
            }
            else
                return "Указанная подстрока не может быть удалена, так как не содержится в исходной строке";
        }
    }
}
