using System;

namespace Lab12.DZ12._2
{
    internal class BookContainer
    {
        public Book[] books;

        public BookContainer(Book[] books)
        {
            this.books = books;
        }

        public delegate int BookComparison(Book a, Book b);

        public void SortBooks(Book[] books, BookComparison comparison)
        {
            Array.Sort(books, (b1, b2) => comparison(b1, b2));//слева входные параметры 
        }
    
    }
}
