using System;
using System.Text;
using System.Globalization;
using System.Reflection;

namespace StringApp
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location);

            Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Заменить в строке все вхождения 'test' на 'testing' и удалить все цифры
                2 -  Задача 2: Вывести на экран фразу Welcome to the TMS lesons
                3 -  Задача 3: Разделить строку на подстроки по разделителю 'abc'
                4 -  Задача 4: Сделать из плохого дня хороший)
                5 -  Задача 5: Набор операций над номерами документов
                6 -  Задача 6: Нормализация строки без методов класса System.String
                7 -  Задача 7: Упорядочивание слов в строке
                """);
            try
            {
                byte task = Convert.ToByte(Console.ReadLine());

                if (task == 0 || task > 7)
                    Console.WriteLine("Вы ввели неправильный номер");

                else
                {
                    switch (task)
                    {
                        case 1:
                            //Создадим изолированный поток для считывания из файла
                            using (var stream = new StreamReader($"{path}\\Files\\InputData_task1.txt"))
                            {
                                string inputString = stream.ReadToEnd();
                                Console.WriteLine($"Входная строка/текст из файла: \n{inputString}");
                                Console.WriteLine($"\nОбработанная строка/текст: \n{Task1.ReplaceSomesubstringAndRemoveAllDigits(inputString, "test", "testing")}");
                            }
                            break;

                        case 2:
                            using (var stream = new StreamReader($"{path}\\Files\\InputData_task2.txt"))
                            {
                                string text = stream.ReadToEnd();
                                string[] words = text.Split(" ");
                                Task2.CollectStringFromArray(words);
                            }
                            break;

                        case 3:
                            using (var stream = new StreamReader($"{path}\\Files\\InputData_task3.txt"))
                            {
                                string inputString = stream.ReadToEnd();
                                Task3.SplitString(inputString, "abc");
                            }
                            break;

                        case 4:
                            Console.WriteLine(Task4.ReplaceWordInString("Плохой день", "Плохой", "Хороший", "!!!!!!!!!", "?")); //вводные закостылены, сорри, тороплюсь)
                            break;

                        case 5:
                            {
                                var substring = "abc";
                                var beginSubstring = "555";
                                var endSubstring = "1a2b";

                                //считывание не в потоке - при большом объеме данных нужно переделать на считывание в потоке и преобразование в массив
                                string[] docNumbers = File.ReadAllLines($"{path}\\Files\\InputData_task5.txt");

                                //выведем все обработанные номера документов в цикле
                                for (byte dn = 0; dn < docNumbers.Length; dn++)
                                {
                                    //уберем лишние символы в начале и конце элемента перед обработкой
                                    docNumbers[dn] = docNumbers[dn].Trim();
                                    Console.WriteLine($"Номер документа: {docNumbers[dn]}");

                                    //обработаем номер, только если он введен корректно
                                    if (Task5.IsCorrectDocNumber(docNumbers[dn]))
                                    {
                                        Console.WriteLine($"Подзадача 1: {Task5.FirstTwoDigitalBlocksInDocNumber(docNumbers[dn])}");
                                        Console.WriteLine($"Подзадача 2: {Task5.ReplaceDocNumberLettersWithAsterisk(docNumbers[dn])}");
                                        Console.WriteLine($"Подзадача 3: {Task5.OnlyLettersOfDocNumberInLowercase(docNumbers[dn])}");
                                        Console.WriteLine($"Подзадача 4: {Task5.OnlyLettersOfDocNumberInUppercase(docNumbers[dn])}");
                                        Console.WriteLine($"Подзадача 5: {Task5.IsDocNumberContainSubString(docNumbers[dn], substring)}");
                                        Console.WriteLine($"Подзадача 6: {Task5.IsDocNumberBeginWithSubstring(docNumbers[dn], beginSubstring)}");
                                        Console.WriteLine($"Подзадача 7: {Task5.IsDocNumberEndWithSubstring(docNumbers[dn], endSubstring)}");
                                    }
                                    else
                                        Console.WriteLine("Номер документа введен неверно");
                                    Console.WriteLine();
                                }
                                break;
                            }

                        case 6:
                            using (var stream = new StreamReader($"{path}\\Files\\InputData_task6.txt"))
                            {
                                string inputString = stream.ReadToEnd();
                                Console.WriteLine(Task6.NormalizeString(inputString));
                            }
                            break;

                        case 7:
                            using (var stream = new StreamReader($"{path}\\Files\\InputData_task6.txt"))
                            {
                                string inputString = stream.ReadToEnd();
                                Console.WriteLine(Task7.SortWordsInString(inputString));
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка - введено некорректное число.\n{ex}");
            }
        }
    }
}
