using OOP.TransportHierarchy;
using OOP.Cars;
using System.Text;
using OOP.GeometricFigures;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Геометрические фигуры
                2 -  Задача 2: Клиника
                3 -  Задача 3: Парк Общественного транспорта
                4 -  Задача 4: Машинки
                """);

        if (Int32.TryParse(Console.ReadLine(), out int task))

            if (task < 1 || task > 4)
                Console.WriteLine("Вы ввели неправильный номер");
            else
                switch (task)
                {
                    case 1: Task1(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;
                }
        else
            Console.WriteLine("Введено некорректное значение");
    }

    private static void Task1()
    {
        GeometricFigure[] figures =
        {
            TriangleCreate.CreateTriangle(3,4,5),
            TriangleCreate.CreateTriangle(12,15,10),
            TriangleCreate.CreateTriangle(5,12,13),
            TriangleCreate.CreateTriangle(5.7f,4.1f,3.2f),
            TriangleCreate.CreateTriangle(3,3,3),
            TriangleCreate.CreateTriangle(6,4,4),
            TriangleCreate.CreateTriangle(10.5f,6,10.5f),
            new Rectangle(4,6),
            new Square(12),
            new Rectangle(14.5f,6.2f),
            new Square(1.2f)
        };

        foreach (var figure in figures)
        {
            figure.PrintInfo();
        }
    }

    private static void Task3()
    {
        PrintRedText("Создание объекта класса Bus и вывод значений его полей в консоль");

        var bus = new TransportBackwardAutomobileBus("62", "Sity", 48, new DateTime(2024, 8, 10));
        bus.PrintInfo();

        //Создадим массив объектов разных типов транспорта
        Transport[] transportArray =
            {
            bus,
            new TransportWaterRiverFerry("18FF","Краснодар",58,new DateTime(2024,1,1)),
            new TransportPersonalBike(new DateTime(2019,10,10),"Black"),
            new TransportBackwardRailwayTram()
            };

        //Вызовем метод PrintTransportServise (вывод информацию по типу транспорта) для объектов разных типов
        PrintRedText("\nВывод информации по типу общественного транспорта для массива объектов разного типа");
        foreach (Transport transport in transportArray)
            TransportService.PrintTransportServise(transport);

        //Создадим массив объектов общественного транспорта
        TransportPublic[] transportPublicArray =
        {
            new TransportAirAeronauticalAirship(),
            new TransportAirAviationAirplane("Air717","Moscow",325,new DateTime(2024,1,12)),
            new TransportBackwardAutomobileBus("108","Краснодар",58,new DateTime(2024,1,1)),
            new TransportBackwardAutomobileTrolleybus("14","Школа 14"),
            new TransportBackwardRailwayTram("8"),
            new TransportWaterRiverFerry("KrMk_115","Краснодар",314,new DateTime(2023,12,31)),
            new TransportWaterSeaCruiseShip("1118","Spain",600,new DateTime(2023,12,20))
        };

        //Выведем всю информацию по объектам общественного транспорта для отсортированного массива
        PrintRedText("\nМассив объектов из различных видов транспорта. Сортировка по количеству мест.");
        var arraySorted = transportPublicArray.OrderBy(key => key.SeatsNumber);

        foreach (TransportPublic transport in arraySorted)
            transport.PrintInfo();

        PrintRedText("Поиск маршрутов по дате отправления. Введите дату: ");
        SearchByDate('=', Console.ReadLine(), transportPublicArray);

        PrintRedText("Поиск маршрутов позже даты отправления. Введите дату: ");
        SearchByDate('>', Console.ReadLine(), transportPublicArray);

        PrintRedText("Поиск маршрута по пункту назначения. Введите пункт: ");
        string? destination = Console.ReadLine();

        if (CheckInput(destination))
            foreach (TransportPublic transport in transportPublicArray)

                if (String.Equals(transport.Destination, destination, StringComparison.CurrentCultureIgnoreCase))
                    transport.PrintInfo();
    }

    private static void Task4()
    {
        //Создадим массив объектов разных типов и выведем информацию по ним
        Auto[] autoArray =
        {
            new PassengerCar("Audi","z000zz",200),
            new Truck("MAN", "yr777", 150, true),
            new Truck("Mersedes", "uu555", 170, false),
            new Motorbike("Yamaha", "mm445", 250, false),
            new Motorbike("Минск", "nm654", 100, true)
        };

        foreach (Auto auto in autoArray)
            auto.GetInfo();

        //Поиск по соответствию требованиям грузоподъемности
        PrintRedText("\nВведите тип операции (<, =, >) и значение грузоподъемности");
        SearchByInt(Console.ReadLine(), Console.ReadLine(), autoArray);
    }

    public static void PrintRedText(string Text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Text);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static bool CheckInput(string? input)
    {
        if (String.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Введена пустая строка");
            return false;
        }
        return true;
    }

    private static bool CheckInput(string? input, out DateTime dateTimeChecked)
    {
        if (CheckInput(input))
            if (DateTime.TryParse(input, out DateTime dateTime))
            {
                dateTimeChecked = dateTime;
                return true;
            }
        Console.WriteLine("Введен некорректный формат даты");
        dateTimeChecked = DateTime.Now;
        return false;
    }

    private static void SearchByDate(char operation, string? date, params TransportPublic[] inputArray)
    {
        if (CheckInput(date, out DateTime dateTimeAfter))
            switch (operation)
            {
                case '=':
                    foreach (TransportPublic transport in inputArray)

                        if (transport.DepartureTime == dateTimeAfter)
                            transport.PrintInfo();
                    break;
                case '>':
                    foreach (TransportPublic transport in inputArray)

                        if (transport.DepartureTime > dateTimeAfter)
                            transport.PrintInfo();
                    break;
                case '<':
                    foreach (TransportPublic transport in inputArray)

                        if (transport.DepartureTime < dateTimeAfter)
                            transport.PrintInfo();
                    break;
                default:
                    Console.WriteLine("Неправильный тип операции");
                    break;
            }
    }

    private static void SearchByInt(string? operation, string? input, params Auto[] inputArray)
    {
        if (Char.TryParse(operation, out char operationValue))
            if (Int32.TryParse(input, out int inputValue))
                foreach (Auto auto in inputArray)
                    switch (operationValue)
                    {
                        case '=':
                            if (auto.LiftingCapacity == inputValue)
                                auto.GetInfo();
                            break;
                        case '>':
                            if (auto.LiftingCapacity > inputValue)
                                auto.GetInfo();
                            break;
                        case '<':
                            if (auto.LiftingCapacity < inputValue)
                                auto.GetInfo();
                            break;
                        default:
                            Console.WriteLine("Неправильный тип операции");
                            break;
                    }
            else
                Console.WriteLine("Введено некорректное значение грузоподъемности");
        else
            Console.WriteLine("Введено некорректное значение типа операции");
    }
}