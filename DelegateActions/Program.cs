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
                2 -  Задача 2: 
                3 -  Задача 3: 
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


                default: Console.WriteLine("Вы ввели неправильный номер"); break;
            }
        }
    }
}