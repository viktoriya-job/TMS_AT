using System.Text;
using Collections.Helper;
using Collections.Task1;
using Collections.Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Библиотека
                2 -  Задача 2: Каталог товаров
                3 -  Задача 3: 
                4 -  Задача 4: 
                """);

        if (CheckInputHelper.IsCorrectInt32(Console.ReadLine(), out int task))
            switch (task)
            {
                case 1:
                    Console.Clear();
                    Task1.Run();
                    break;
                case 2:
                    Console.Clear();
                    Task2.Run();
                    break;
                //case 3: Task3(); break;
                //case 4: Task4(); break;

                default:
                    Console.WriteLine("Вы ввели неправильный номер");
                    break;
            }
    }
}