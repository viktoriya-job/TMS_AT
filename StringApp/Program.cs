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
            byte task = Convert.ToByte(Console.ReadLine());

            if (task == 0 || task > 7)
                Console.WriteLine("Вы ввели неправильный номер");

            else
            {
                switch (task)
                {
                    case 1:
                        using (var stream = new StreamReader($"{path}\\Files\\InputData_task1.txt"))
                        {
                            string inputString = stream.ReadToEnd();
                            Console.WriteLine($"Входная строка/текст из файла: \n{inputString}");
                            Console.WriteLine($"\nОбработанная строка/текст: \n{Task1.ReplaceSomesubstringAndRemoveAllDigits(inputString, "test", "testing")}");
                        }
                        break;

                    case 2:
                        using (var stream = new StreamReader($"{path}\\Files\\InputData_task2.txt")) //наверняка можно считывать сразу в массив, не разобралась пока
                        {
                            string text = stream.ReadToEnd();
                            string[] words = text.Split(" ");
                            Task2.CollectStringFromArray(words);

                        }
                        break;

                    case 3:
                        using (var stream = new StreamReader($"{path}\\Files\\InputData_task3.txt")) //наверняка можно считывать сразу в массив, не разобралась пока
                        {
                            string inputString = stream.ReadToEnd();
                            Task3.SplitString(inputString, "abc");

                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine(Task4.ReplaceWordInString("Плохой день", "Плохой", "Хороший", "!!!!!", "?")); //не считываю из файла, сорри, тороплюсь
                            break;
                        }


                }

            }


        }
    }
}
