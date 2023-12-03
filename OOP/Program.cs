using OOP.TransportHierarchy;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

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
            {
                switch (task)
                {
                    case 3: Task3(); break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка - введено некорректное число.\n{ex}");
        }
    }

    private static void Task3()
    {
        Transport.PrintRedText("Создадим объект класса Bus и выведем значения его полей в консоль");

        var bus = new TransportBackwardAutomobileBus("62", "Sity", 48, new DateTime(2024, 8, 10));
        Console.WriteLine(bus.GetTransportInfo());

        Transport.PrintRedText("Создадим массив различных объектов");
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

        Transport.PrintRedText("Выведем созданный массив");
        foreach (Transport transport in transportArray)
            Console.WriteLine(transport.GetTransportInfo());

        Transport.PrintRedText("Отсортированный по количеству мест массив");
        var arraySorted = transportArray.OrderBy(key => key.SeatsNumber);

        foreach (Transport transport in arraySorted)
            Console.WriteLine(transport.GetTransportInfo());

        //Поиск по времени
        Transport.PrintRedText("Введите дату отправления для поиска объекта: ");

        if(DateTime.TryParse(Console.ReadLine(),out DateTime dateTime))
        {
            foreach(Transport transport in transportArray)

                if (transport.DepartureTime == dateTime)
                    Console.WriteLine(transport.GetTransportInfo());
        }
        else Console.WriteLine("Введен некорректный формат даты");

        //Поиск по пункту назначения
        Transport.PrintRedText("Введите пункт назначения для поиска объекта: ");
        string? destination = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(destination))
            Console.WriteLine("Введена пустая строка");
        else
            foreach (Transport transport in transportArray)

                if (transport.Destination == destination)
                    Console.WriteLine(transport.GetTransportInfo());

        //Поиск маршрутов после заданного времени
        Transport.PrintRedText("Введите дату для поиска маршрута позднее нее");

        if (DateTime.TryParse(Console.ReadLine(), out DateTime dateTimeAfter))
        {
            foreach (Transport transport in transportArray)

                if (transport.DepartureTime > dateTimeAfter)
                    Console.WriteLine(transport.GetTransportInfo());
        }
        else Console.WriteLine("Введен некорректный формат даты");

    }
}