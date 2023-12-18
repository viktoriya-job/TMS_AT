using System.Text;
using Collections.Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Библиотека
                2 -  Задача 2: 
                3 -  Задача 3: 
                4 -  Задача 4: 
                """);

        if (Int32.TryParse(Console.ReadLine(), out int task))
            if (task < 1 || task > 4)
                Console.WriteLine("Вы ввели неправильный номер");
            else
                switch (task)
                {
                    case 1:
                        Console.Clear(); 
                        Task1.Run(); 
                        break;
                    //case 2: Task2(); break;
                    //case 3: Task3(); break;
                    //case 4: Task4(); break;
                }
        else
            Console.WriteLine("Введено некорректное значение");
    }
}