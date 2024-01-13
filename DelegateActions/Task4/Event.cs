﻿namespace Delegate
{
    internal class Event
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Event(string title, DateTime date, string description)
        {
            Title = title;
            Date = date;
            Description = description;
        }
    }
}