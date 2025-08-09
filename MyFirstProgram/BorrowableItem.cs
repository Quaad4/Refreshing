using System;

namespace MyFirstProgram
{
    abstract class BorrowableItem : LibraryItem, IBorrowable
    {
        public string BorrowerName { get; private set; }
        public bool IsBorrowed { get; private set; }

        public BorrowableItem(string title) : base(title)
        {

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
                BorrowerName = "";
            }
            else
            {
                Console.WriteLine($"{Title} is not currently borrowed.");
            }
        }
    }
}
