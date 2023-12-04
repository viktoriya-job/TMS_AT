using OOP.TransportHierarchy;
using System.Reflection.Metadata.Ecma335;
using System.Text;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
                Выберите задачу:
                1 -  Задача 1: Геометрические фигуры
                2 -  Задача 2: Клиника
                3 -  Задача 3: Парк Общественного транспорта
                4 -  Задача 4: Машинки
                """);
        try
        {
            byte task = Convert.ToByte(Console.ReadLine());

            if (task == 0 || task > 4)
                Console.WriteLine("Вы ввели неправильный номер");
            else
                switch (task)
                {
                    case 3: Task3(); break;
                }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка - введено некорректное число.\n{ex}");
        }
    }

    private static void Task3()
    {
        PrintRedText("Создадим объект класса Bus и выведем значения его полей в консоль");

        var bus = new TransportBackwardAutomobileBus("62", "Sity", 48, new DateTime(2024, 8, 10));
        Console.WriteLine(bus.GetTransportInfo());

        //Создадим массив объяктов разных типов
        Transport[] transportArray =
        {
            new TransportAirAeronauticalAirship(),
            new TransportAirAviationAirplane("Air717","Moscow",325,new DateTime(2024,1,1)),
            new TransportBackwardAutomobileBus("108","Краснодар",58,new DateTime(2024,1,1)),
            new TransportBackwardAutomobileTrolleybus("14","Школа 14"),
            new TransportBackwardRailwayTram("8"),
            new TransportWaterRiverFerry("KrMk_115","Краснодар",314,new DateTime(2023,12,31)),
            new TransportWaterRiverTram("56F","ЖК Адмирал",110,new DateTime(2024,01,12)),
            new TransportWaterSeaBoat("-","Sochy",20,new DateTime(2024,8,13)),
            new TransportWaterSeaCruiseShip("1118","Spain",600,new DateTime(2023,12,20))
        };

        //Вызовем метод PrintTransportServise для объектов разных типов - сразу для отсортированного массива
        PrintRedText("Массив объектов из различных видов транспорта. Сортировка по количеству мест.");
        var arraySorted = transportArray.OrderBy(key => key.SeatsNumber);

        foreach (Transport transport in arraySorted)
            TransportService.PrintTransportServise(transport);

        PrintRedText("Поиск маршрутов по дате отправления. Введите дату: ");
        SearchByDate('=', Console.ReadLine(), transportArray);

        PrintRedText("Поиск маршрутов позже даты отправления. Введите дату: ");
        SearchByDate('>', Console.ReadLine(), transportArray);

        PrintRedText("Поиск маршрута по пункту назначения. Введите пункт: ");
        string? destination = Console.ReadLine();

        if (CheckInput(destination))
            foreach (Transport transport in transportArray)

                if (transport.Destination == destination)
                    Console.WriteLine(transport.GetTransportInfo());
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

    private static void SearchByDate(char operation, string? date, params Transport[] transportArray)
    {
        if (CheckInput(date, out DateTime dateTimeAfter))
            switch (operation)
        {
            case '=':
                    foreach (Transport transport in transportArray)

                        if (transport.DepartureTime == dateTimeAfter)
                            Console.WriteLine(transport.GetTransportInfo());
                break;
            case '>':
                    foreach (Transport transport in transportArray)

                        if (transport.DepartureTime > dateTimeAfter)
                            Console.WriteLine(transport.GetTransportInfo());
                break;
            case '<':
                    foreach (Transport transport in transportArray)

                        if (transport.DepartureTime < dateTimeAfter)
                            Console.WriteLine(transport.GetTransportInfo());
                break;
            default:
                Console.WriteLine("Неправильный код операции");
                break;
        }

    }
}