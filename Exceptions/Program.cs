using System.Text;
using Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Проверка данных при регистрации
                2 -  Задача 2: 
                """);

        if (Int32.TryParse(Console.ReadLine(), out int task))
            if (task < 1 || task > 2)
                Console.WriteLine("Вы ввели неправильный номер");
            else
                switch (task)
                {
                   case 1: Task1.Run(); break;
                    //case 2: Task2(); break;
                }
        else
            Console.WriteLine("Введено некорректное значение");
    }
}