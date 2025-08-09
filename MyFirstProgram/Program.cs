using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            Book book = new Book("Clean Code", "Robert C. Martin");
            Magazine magazine = new Magazine("The Lord of the Rings", 123);
            DVD dvd = new DVD("The Matrix", 160);

            Library library = new Library();
            library.AddItems(new LibraryItem[] { book, magazine, dvd });

            Console.WriteLine("All Items:");
            library.ListAllItems();

            Console.WriteLine();
            Console.WriteLine("Available Items:");
            library.ListAvailableItems();

            Console.WriteLine();
            library.FindByTitle("test"); // Expected No Titles found with that name
            library.FindByTitle("Clean Code");

            library.BorrowItemById(3, "Alex");

            Console.ReadKey();
        }
    }
}