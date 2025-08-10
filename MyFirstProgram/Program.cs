using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool running = true;
            Library library = new Library();

            // Add some initial items for testing
            library.AddItems(new LibraryItem[]
            {
                new Book("Clean Code", "Robert C. Martin"),
                new Magazine("National Geographic", 100),
                new DVD("The Matrix", 160)
            });

            while (running)
            {
                Console.Clear();
                Console.WriteLine("===== Library Menu =====");
                Console.WriteLine("1. Show all items");
                Console.WriteLine("2. Show available items");
                Console.WriteLine("3. Find by title");
                Console.WriteLine("4. Borrow item");
                Console.WriteLine("5. Return item");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        library.ListAllItems();
                        break;
                    case "2":
                        library.ListAvailableItems();
                        break;
                    case "3":
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        library.FindByTitle(title);
                        break;
                    case "4":
                        Console.Write("Enter the item ID to borrow: ");
                        string input = Console.ReadLine()?.Trim();
                        Console.Write("Enter your name: ");
                        string borrower = Console.ReadLine()?.Trim();
                        if (int.TryParse(input, out int id))
                        {
                            library.BorrowItemById(id, borrower);
                        }
                        else
                        {
                            Console.WriteLine("Invalid id input. Please enter a number.");
                        }
                        break;
                    case "5":
                        Console.Write("Enter item ID: ");
                        int returnId = int.Parse(Console.ReadLine());
                        library.ReturnItemById(returnId);
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                }
            }

        }
    }
}