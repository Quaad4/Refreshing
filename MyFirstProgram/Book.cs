using System;

namespace MyFirstProgram
{
    class Book : BorrowableItem
    {
        public string Author { get; set; }

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book [Id: {Id}] - \"{Title}\" by {Author}");
        }
    }
}