using System;


namespace MyFirstProgram
{
    interface IBorrowable
    {
        bool IsBorrowed { get; }

        void Borrow(string borrowerName);
        void Return();
    }
}