using System;

namespace Users2
{
    enum Hobbies
    {
       Музыка,
       Танцы,
       Рисование
    }
    internal class Person
    {
        public string name;
        public Hobbies hobby; 

       public Person(string name, Hobbies hobby)
        {
            this.name = name;
            this.hobby = hobby;
        }

        public void ReactionToEvent(Hobbies eventType, string eventName)
        {
            //Console.WriteLine($"Реакция {Person.name}:"); хотела сделать так
            switch (eventType)
            {
                case Hobbies.Музыка:
                    Console.WriteLine($"Оаоао, я обязательно пойду на {eventName}"); break;
                case Hobbies.Танцы: 
                    Console.WriteLine($"О, наконец-то схожу на <{eventName}>"); break;
                case Hobbies.Рисование: 
                    Console.WriteLine($"Интересно посмотреть на работы других, нужно сходить на <{eventName}>"); break;
            }
            
        }
    }
}
