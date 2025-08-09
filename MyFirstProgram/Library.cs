using System;

namespace MyFirstProgram
{
    class Library
    {
        private List<LibraryItem> Items = new List<LibraryItem>();

        public void ListAllItems()
        {
            foreach (LibraryItem item in Items)
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
            Items.AddRange(items);
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
            foreach (LibraryItem item in Items)
            {
                if (item.Title.ToLower() == title.Trim().ToLower())
                {
                    item.DisplayInfo();
                    itemFound = true;
                }
            }
            if (!itemFound)
            {
                Console.WriteLine("No Titles found with that name");
            }
        }

        public void BorrowItemById(int id, string borrowerName)
        {
            var item = Items.FirstOrDefault(item => item.Id == id);
            if (item == null)
            {
                Console.WriteLine("No item found with that ID.");
                return;
            }

            if (item is IBorrowable borrowableItem)
            {
                borrowableItem.Borrow(borrowerName);
            }
            else
            {
                Console.WriteLine($"{item.Title} cannot be borrowed.");
            }
        }

        public void ReturnItemById(int id)
        {
            var item = Items.FirstOrDefault(item => item.Id == id);
            if (item == null)
            {
                Console.WriteLine("No item found with that ID.");
                return;
            }

            if (item is IBorrowable borrowableItem)
            {
                borrowableItem.Return();
            }
            else
            {
                Console.WriteLine($"{item.Title} cannot be returned.");
            }
        }
    }
}
