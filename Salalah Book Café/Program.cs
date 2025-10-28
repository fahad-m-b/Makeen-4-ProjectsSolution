using _4_Projects.Project2.Models;
using _4_Projects.Salalah_Book_Café.Models;

namespace Salalah_Book_Café
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafe cafe = new Cafe();

            cafe.AddMenuItem("Coffee", 3);
            cafe.AddMenuItem("Tea", 1);
            cafe.AddMenuItem("Latte", 3);

            cafe.AddBook("blood meridian");
            cafe.AddBook("i have no mouth and i must scream");
            cafe.AddBook("To Kill a Mockingbird");

            Customer c1 = new Customer("fahad");
            cafe.AddCustomer(c1);

            c1.OrderDrink(cafe.Menu[0]);
            c1.OrderDrink(cafe.Menu[1]);

            c1.BorrowBook(cafe.Books[0]);
            c1.BorrowBook(cafe.Books[1]);

            c1.ShowInfo();

            c1.ReturnAllBooks();

            Console.WriteLine("\n--- After returning books ---");
            c1.ShowInfo();
        }
    }
}
