using System;

namespace MyFirstProgram
{
    abstract class LibraryItem
    {
        private static int NextId = 1;
        public int Id { get; }
        public string Title { get; set; }

        public LibraryItem(string title)
        {
            Id = NextId++;
            Title = title;
        }

        public abstract void DisplayInfo();
    }
}