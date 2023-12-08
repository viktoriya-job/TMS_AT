using System.Text;
using AbstractsInterfaces.GeometricFigures;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Геометрические фигуры
                2 -  Задача 2: Товары
                3 -  Задача 3: Система учета документов
                """);

        if (Int32.TryParse(Console.ReadLine(), out int task))
            if (task < 1 || task > 3)
                Console.WriteLine("Вы ввели неправильный номер");
            else
                switch (task)
                {
                    case 1: Task1(); break;
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                }
        else
            Console.WriteLine("Введено некорректное значение");
    }

    private static void Task1()
    {
        GeometricFigure[] figures =
        {
            new Triangle(3,4,5),
            new Rectangle(5,6),
            new Round (5),
            new Triangle(10,10,10),
            new Rectangle(15,6),
        };

        float sumPerimeter = 0;
        float sumArea = 0;

        foreach (var figure in figures)
        {
            sumPerimeter += figure.GetPerimeter();
            sumArea += figure.GetArea();
        }

        Console.WriteLine($"""
            Сумма периметров:   {sumPerimeter}
            Сумма площадей:     {sumArea}
            Общая сумма:        {sumPerimeter + sumArea}
            """);
    }

    private static void Task2()
    {
        Console.WriteLine("Task2");
    }

    private static void Task3()
    {
        Console.WriteLine("Task3");
    }
}