using System.Collections;
using System.Collections.Generic;

namespace Collections.Helper
{
    internal class PrintHelper
    {
        public static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                if (item is DictionaryEntry)
                {
                    // Обработка случая словаря
                    var entry = (DictionaryEntry)item;
                    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
                }
                else
                {
                    // Обработка других случаев
                    Console.Write($"{item} ");
                }
            }
        }

        public static void PrintRedText(string Text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
