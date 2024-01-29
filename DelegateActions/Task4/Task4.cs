namespace Delegate
{
    internal class Task4
    {
        public void Run()
        {
            Calendar calendar = new Calendar();
            calendar.AddEvent(new Event("Сегодняшнее событие 1", DateTime.Now, "Описание события 1"));
            calendar.AddEvent(new Event("Событие 2 в будущем", new DateTime(2024, 02, 28), "Описание события 2"));
            calendar.AddEvent(new Event("Событие 3 в прошлом", new DateTime(2023, 12, 12), "Описание события 3"));

            calendar.Notify += PrintInfo;
            calendar.GetNotifications();
        }

        public void PrintInfo(Event @event)
        {
            Console.WriteLine($"{@event.Title}, {@event.Description}, Дата проведения: {@event.Date}");
        }
    }
}