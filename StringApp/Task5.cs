using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringApp
{
    internal class Task5
    {
        const string errorTextIfDocNumberIsIncorrect = "Номер документа введен неверно";

        //проверить ворректность формата
        public static bool IsCorrectDocNumber(string docNumber)
        {
            return Regex.IsMatch(docNumber, @"^\d{4}-[a-z]{3}-\d{4}-[a-z]{3}-\d[a-z]\d[a-z]", RegexOptions.IgnoreCase);
        }

        //Вывести в одну строку два первых блока по 4 цифры
        public static string FirstTwoDigitalBlocksInDocNumber(string docNumber)
        {
            if (IsCorrectDocNumber(docNumber))
            {
                var regex = new Regex(@"\d{4}");
                var stringBuilder = new StringBuilder();
                MatchCollection matchCollect = regex.Matches(docNumber);

                if (matchCollect.Count > 0) //излишне, но оставила для себя - не забыть о полезной конструкции
                {
                    foreach (Match match in matchCollect)
                        stringBuilder.Append(match.Value);
                    return stringBuilder.ToString();
                }
                else return errorTextIfDocNumberIsIncorrect;
            }
            else return errorTextIfDocNumberIsIncorrect;
        }

        //Вывести номер документа, но блоки из трех букв заменить на***
        public static string ReplaceDocNumberLettersWithAsterisk(string docNumber)
        {
            if (IsCorrectDocNumber(docNumber))
                return new Regex(@"[a-zA-Z]{3}").Replace(docNumber, "***");
            else
                return errorTextIfDocNumberIsIncorrect;
        }

        //Вывести только одни буквы из номера документа в
        //формате yyy/yyy/y/y в нижнем регистре
        public static string OnlyLettersOfDocNumberInLowercase(string docNumber)
        {
            if (IsCorrectDocNumber(docNumber))
            {
                var stringBuilder = new StringBuilder();
                for (byte i = 0; i < docNumber.Length; i++)
                {
                    if (Char.IsLetter(docNumber[i]))
                    {
                        stringBuilder.Append(docNumber[i]);
                        if (i != docNumber.Length - 1) //чтобы не свалиться в эсепшн; некрасиво, попробую доработать алгоритм, когда будет время
                            if (Char.IsLetter(docNumber[i + 1]) == false)
                                stringBuilder.Append("/");
                    }

                }
                return stringBuilder.ToString().ToLower();
            }
            else
                return errorTextIfDocNumberIsIncorrect;
        }

        //Вывести только одни буквы из номера документа в
        //формате yyy/yyy/y/y в верхнем регистре
        public static string OnlyLettersOfDocNumberInUppercase(string docNumber)
        {
            if (IsCorrectDocNumber(docNumber))
            {
                var stringBuilder = new StringBuilder();
                for (byte i = 0; i < docNumber.Length; i++)
                {
                    if (Char.IsLetter(docNumber[i]))
                    {
                        stringBuilder.Append(docNumber[i]);
                        if (i != docNumber.Length - 1)
                            if (Char.IsLetter(docNumber[i + 1]) == false)
                                stringBuilder.Append("/");
                    }
                }
                return stringBuilder.ToString().ToUpper();
            }
            else
                return errorTextIfDocNumberIsIncorrect;
        }

        //Проверить, содержит ли номер документа последовательность
        public static string IsDocNumberContainSubString(string docNumber, string subString)
        {
            if (IsCorrectDocNumber(docNumber))
                if (Regex.IsMatch(docNumber, subString, RegexOptions.IgnoreCase))
                    return $"Номер документа содержит подстроку {subString}";
                else
                    return $"Номер документа не содержит подстроку {subString}";
            else
                return errorTextIfDocNumberIsIncorrect;
        }

        //Проверить, начинается ли номер документа с последовательности
        public static string IsDocNumberBeginWithSubstring(string docNumber, string subString)
        {
            if (IsCorrectDocNumber(docNumber))
            {
                if (docNumber.StartsWith(subString))
                    return $"Номер документа начинается с {subString}";
                else
                    return $"Номер документа не начинается с {subString}";
            }
            else
                return errorTextIfDocNumberIsIncorrect;
        }

        //Проверить, заканчивается ли номер документа на последовательность

        public static string IsDocNumberEndWithSubstring(string docNumber, string subString)
        {
            if (IsCorrectDocNumber(docNumber))
            {
                if (docNumber.EndsWith(subString))
                    return $"Номер документа заканчивается последовательностью {subString}";
                else
                    return $"Номер документа не заканчивается последовательностью {subString}";
            }
            else
                return errorTextIfDocNumberIsIncorrect;
        }
    }
}
