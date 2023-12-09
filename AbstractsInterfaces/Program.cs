using System.Text;
using AbstractsInterfaces.GeometricFigures;
using AbstractsInterfaces.Products;

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

        Foodstuff cheese1 = new Foodstuff("Сыр Эмменталь 100 гр", 400, new DateOnly(2023, 10, 18), 60);
        Foodstuff cheese2 = new Foodstuff("Сыр Гауда 100 гр", 500, new DateOnly(2023, 11, 01), 50);
        Foodstuff cheese3 = new Foodstuff("Сыр Маздам 100 гр", 600, new DateOnly(2023, 12, 01), 30);
        Foodstuff yogurt1 = new Foodstuff("Йогурт греческий", 40, new DateOnly(2023, 11, 01), 20); //просроченный =\
        Foodstuff yogurt2 = new Foodstuff("Йогурт греческий вишневый", 50, new DateOnly(2023, 12, 08), 20); // а этот свежий

        Product[] products =
        {
            cheese1, cheese2, cheese3, yogurt1, yogurt2,
            new Set("Сырный набор", 1300, new List<Foodstuff> { cheese1, cheese2, cheese3 }),
            new Set("Набор йогуртов", 150, new List<Foodstuff> { yogurt1, yogurt1, yogurt2, yogurt2 }), //набор просрочен, так как в него входит просроченный йогурт
            new Foodstuff("Яблоки сезонные 1 кг", 500, new DateOnly(2023, 11, 01), 50),
            new Batch("Хлеб ржаной", 65.5f, new DateOnly(2023, 12, 09), 7, 50)
        };

        foreach (Product product in products)
            product.PrintInfo();

        Console.WriteLine("\nПросроченные товары:");
        foreach (Product product in products)
            if (!product.IsNotExpired())
                Console.WriteLine(product.Title);
    }

    private static void Task3()
    {
        Console.WriteLine("Task3");
    }
}