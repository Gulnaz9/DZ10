
namespace Lab12.DZ12._2
{
    internal class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }

        public Book(string title, string author, string publisher)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
        }
    }
}
