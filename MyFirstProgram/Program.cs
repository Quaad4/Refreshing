using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            Book book = new Book("Clean Code", "Robert C. Martin");
            book.DisplayInfo();
            Console.ReadKey();
        }
    }

    abstract class LibraryItem
    {
        public static int _NextId;
        public int Id { get; }
        public string Title { get; set; }

        public LibraryItem(string title)
        {
            Id = _NextId++;
            Title = title;
        }

        public abstract void DisplayInfo();
    }

    class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book [id: {Id}] - \'{Title}\' by {Author}");
        }

    }
}