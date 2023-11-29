using System;
using System.Collections.Generic;

namespace Users2
{
    internal class Events
    {
        public string eventName;
        public DateTime date;
        public Hobbies eventType;//тип события по хобби

        public Events(string eventName, DateTime date, Hobbies eventType)
        {
            this.eventName = eventName;
            this.date = date;
            this.eventType = eventType;
        }

        public static void AddEventToList(List<Events> Events, Events events)
        {
            Events.Add(events); // добавляем объект в список
        }
    }
}
