using Lab12.DZ12._2;
using Lab12.Ex1;
using System;

namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 12.1, для класса банковский счет переопределить операторы и методы");

            Bank B1 = new Bank(123456789, 2430);
            Bank B2 = new Bank(321654987, 4230);

            Console.WriteLine($"Первый аккаунт- {B1}\nВторой аккаунт- {B2}");
            Console.WriteLine("Эти аккаунты одинаковые? " + (B1 == B2));
            Console.WriteLine("Эти аккаунты не одинаковые? " + (B1 != B2));



            Console.WriteLine("\nДз 12.2, про массив книг и их сортировку");
            Book[] books = new Book[]
        {
            new Book("Тень и кость", "Ли Бардуго", "Издательство АСТ"),
            new Book("Шестёрка воронов", "Ли Бардуго", "Издательство АСТ"),
            new Book("Медвежий угол", "Фредрик Бакман", "Синдбад")
        };

            BookContainer sorter = new BookContainer(books);

            // Сортировка по названию
            sorter.SortBooks(books, (t1, t2) => String.Compare(t1.title, t2.title));

            // Сортировка по автору
            sorter.SortBooks(books, (a1, a2) => String.Compare(a1.author, a2.author));

            // Сортировка по издательству
            sorter.SortBooks(books, (p1, p2) => String.Compare(p1.publisher, p2.publisher));
        }
    }
}
