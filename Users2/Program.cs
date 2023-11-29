using System;
using System.Collections.Generic;

namespace Users2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Задача 2, написать программу для слежения за интересующим вас событием");

            Person Giselle = new Person("Жизель", Hobbies.Музыка);
            Person Hyunjin = new Person("Хёнджин", Hobbies.Рисование);
            Person Minho = new Person("Минхо", Hobbies.Танцы);

            Events MusicConcert1 = new Events("Концерт Тря Дня Дождя", new DateTime(2023, 11, 28), Hobbies.Музыка);
            Events MusicConcert2 = new Events("Концерт ЛСП", new DateTime(2023, 12, 2), Hobbies.Музыка);
            Events DancePractice = new Events("Танцевальная практика", new DateTime(2023, 12, 3), Hobbies.Танцы);
            Events ArtShow = new Events("Арт-выставка", new DateTime(2023, 12, 15), Hobbies.Рисование);

            List<Events> events = new List<Events>();
            Events.AddEventToList(events, MusicConcert1);
            Events.AddEventToList(events, MusicConcert2);
            Events.AddEventToList(events, DancePractice);
            Events.AddEventToList(events, ArtShow);

            Console.WriteLine("Введите событие(концерт, танцы, выставка)");
            string user = Console.ReadLine();
            switch(user)
            {
                case "концерт":
                    Console.WriteLine($"Реакция {Giselle.name}:");
                    Giselle.ReactionToEvent(Hobbies.Музыка, MusicConcert1.eventName);
                    Giselle.ReactionToEvent(Hobbies.Музыка, MusicConcert2.eventName); break;
                case "танцы": Console.WriteLine($"Реакция {Minho.name}:"); 
                    Minho.ReactionToEvent(Hobbies.Танцы, DancePractice.eventName); break;
                case "рисование": Console.WriteLine($"Реакция {Hyunjin.name}:"); 
                    Hyunjin.ReactionToEvent(Hobbies.Рисование, ArtShow.eventName); break;
            }

        }
    }
}
