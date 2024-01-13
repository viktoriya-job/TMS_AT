using System.Text;
using Delegate;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Делегат без входных параметров
                2 -  Задача 2: Рассчет математических величин, делегат
                3 -  Задача 3: Сортировки
                4 -  Задача 4:
                """);

        if (CheckInputHelper.IsCorrectInt32(Console.ReadLine(), out int task))
        {
            Console.Clear();
            switch (task)
            {
                case 1:
                    Task1 task1 = new Task1();
                    task1.Run();
                    break;

                case 2:
                    Task2 task2 = new Task2();
                    task2.Run();
                    break;

                case 3:
                    Task3 task3 = new Task3();
                    task3.Run();
                    break;

                default: Console.WriteLine("Вы ввели неправильный номер"); break;
            }
        }
    }
}