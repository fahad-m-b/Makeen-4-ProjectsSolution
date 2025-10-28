using _4_Projects.Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Salalah_Book_Café.Models
{
    public class Cafe
    {
        public List<MenuItem> Menu { get; set; }
        public List<Book> Books { get; set; }
        public List<Customer> Customers { get; set; }

        public Cafe()
        {
            Menu = new List<MenuItem>();
            Books = new List<Book>();
            Customers = new List<Customer>();
        }

        public void AddMenuItem(string name, int price)
        {
            Menu.Add(new MenuItem(name, price));
        }

        public void AddBook(string title)
        {
            Books.Add(new Book(title));
        }

        public void AddCustomer(Customer c)
        {
            Customers.Add(c);
        }
    }
}
