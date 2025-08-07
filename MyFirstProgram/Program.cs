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
            library.AddItems([book, magazine, dvd]);

            Console.WriteLine("All Items:");
            library.ListAllItems();

            Console.WriteLine();
            Console.WriteLine("Available Items:");
            library.ListAvailableItems();

            Console.WriteLine();
            library.FindByTitle("test"); // Expected No Titles found with that name
            library.FindByTitle("Clean Code");

            Console.ReadKey();
        }
    }

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

    class Book : LibraryItem, IBorrowable
    {
        public string Author { get; set; }
        public string BorrowerName { get; set; }
        public bool IsBorrowed { get; private set;  }

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book [Id: {Id}] - \"{Title}\" by {Author}");
        }

        public void Borrow(string borrowerName)
        {
            if (!IsBorrowed)
            {
                BorrowerName = borrowerName;
                IsBorrowed = true;
                Console.WriteLine($"{Title} has been borrowed by {BorrowerName}.");
            }
            else
            {
                Console.WriteLine($"{Title} is already borrowed.");
            }
        }

        public void Return()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"{Title} has been returned by {BorrowerName}.");
                IsBorrowed = false;
                BorrowerName = null;
            }
            else
            {
                Console.WriteLine($"{Title} is not currently borrowed.");
            }
        }

    }

    class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int issueNumber) : base(title)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine [Id: {Id}] - \"{Title}\" Issue #{IssueNumber}");
        }
    }

    class DVD : LibraryItem, IBorrowable
    {
        public int DurationInMinutes { get; set; }
        public string BorrowerName { get; set; }
        public bool IsBorrowed { get; private set; }

        public DVD(string title, int durationInMinutes) : base(title)
        {
            DurationInMinutes = durationInMinutes;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"DVD [Id: {Id}] - \"{Title}\" - Duration: {DurationInMinutes} minutes");
        }

        public void Borrow(string borrowerName)
        {
            if (!IsBorrowed)
            {
                BorrowerName = borrowerName;
                IsBorrowed = true;
                Console.WriteLine($"{Title} has been borrowed by {BorrowerName}.");
            }
            else
            {
                Console.WriteLine($"{Title} is already borrowed.");
            }
        }

        public void Return()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"{Title} has been returned by {BorrowerName}.");
                IsBorrowed = false;
                BorrowerName = null;
            }
            else
            {
                Console.WriteLine($"{Title} is not currently borrowed.");
            }
        }
    }

    interface IBorrowable
    {
        bool IsBorrowed { get; }

        void Borrow(string borrowerName);
        void Return();
    }

    class Library
    {
        private List<LibraryItem> Items = [];

        public void ListAllItems()
        {
            foreach(LibraryItem item in Items)
            {
                item.DisplayInfo();
            }
        }

        public void AddItem(LibraryItem item) 
        {
            Items.Add(item);
        }

        public void AddItems(LibraryItem[] items)
        {
            foreach(LibraryItem item in items)
            {
                Items.Add(item);
            }
        }

        public void ListAvailableItems()
        {
            foreach (LibraryItem item in Items)
            {
                if (item is IBorrowable borrowableItem)
                {
                    if (!borrowableItem.IsBorrowed)
                    {
                        item.DisplayInfo();
                    }
                }
                else
                {
                    item.DisplayInfo();
                }
            }
        }

        public void FindByTitle(string title)
        {
            bool itemFound = false;
            foreach(LibraryItem item in Items)
            {
                if(item.Title.ToLower() == title.Trim().ToLower())
                {
                    item.DisplayInfo();
                    itemFound = true;
                }
            }
            if(!itemFound)
            {
                Console.WriteLine("No Titles found with that name");
            }
        }
    }
}