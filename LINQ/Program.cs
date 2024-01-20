using System.Text;
using LINQ;
using LINQ.Helper;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Выбор нечетных элементов целочисленной последовательности без повторов
                2 -  Задача 2: Мин продолжительность занятий среди клиентов фитнес-центра
                3 -  Задача 3: Сортировка строковой последовательности
                4 -  Задача 4: Выборка из двух последовательностей
                """);

        if (CheckInputHelper.IsCorrectInt32(Console.ReadLine(), out int task))
        {
            Console.Clear();
            switch (task)
            {
                case 1: Task1.Run(); break;
                case 2: Task2.Run(); break;
                case 3: Task3.Run(); break;
                case 4: Task4.Run(); break;
                default: Console.WriteLine("Вы ввели неправильный номер"); break;
            }
        }
    }
}