using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Project2.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<MenuItem> Orders { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public Customer(string name)
        {
            Name = name;
            Orders = new List<MenuItem>();
            BorrowedBooks = new List<Book>();
        }
        public void OrderDrink(MenuItem item)
        {
            Orders.Add(item);
            Console.WriteLine($"{Name} Ordered:{item.Name}");
        }
        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >= 2)
            {
                Console.WriteLine($"{Name} cannot borrow more than 2 books!");
                return;
            }
            if (book.IsBorrowed)
            {
                Console.WriteLine($"{book.Title} is already borrowed!");
                return;
            }

            BorrowedBooks.Add(book);
            book.IsBorrowed = true;
            Console.WriteLine($"{Name} borrowed '{book.Title}'");
        }
        public void ReturnAllBooks()
        {
            foreach (var book in BorrowedBooks)
            {
                book.IsBorrowed = false;
                Console.WriteLine($"{Name} returned '{book.Title}'");
            }
            BorrowedBooks.Clear();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Customer: {Name}\nOrders:");
            foreach (var item in Orders)
                Console.WriteLine($" - {item.Name} ({item.Price} OMR)");

            Console.WriteLine("Borrowed Books:");
            if (BorrowedBooks.Count == 0)
                Console.WriteLine(" - None");
            else
                foreach (var b in BorrowedBooks)
                    Console.WriteLine($" - {b.Title}");
        }
    }
}
