using System.Text;
using Generics;
using Generics.Helper;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Координаты точки
                2 -  Задача 2: Массив обобщенного типа
                3 -  Задача 3: 
                """);

        if (CheckInputHelper.IsCorrectInt32(Console.ReadLine(), out int task))
        {
            Console.Clear();
            switch (task)
            {
                case 1: Task1.Run(); break;
                case 2: Task2.Run(); break;
                //case 3: Task3.Run(); break;
                default: Console.WriteLine("Вы ввели неправильный номер"); break;
            }
        }
    }
}