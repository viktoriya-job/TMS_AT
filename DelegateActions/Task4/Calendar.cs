namespace Delegate
{
    internal class Calendar
    {
        public delegate void EventHandler(Event @event);
        public event EventHandler Notify;
        public List<Event> Events { get; set; } = new List<Event>();
        public Calendar() { }

        public void AddEvent(Event @event)
        {
            Events.Add(@event);
        }

        public void GetNotifications()
        {
            foreach (Event @event in Events)
                if (DateOnly.FromDateTime(@event.Date).Equals(DateOnly.FromDateTime(DateTime.Now)))
                {
                    Notify.Invoke(@event);
                }
        }
    }
}