using _4_Projects.Dhofar_Car_Rental.Models;

namespace Dhofar_Car_Rental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalSystem system = new RentalSystem();

            system.AddCar(new Car { Id = 1, Make = "Toyota", Model = "Corolla", Price = 15 });
            system.AddCar(new Car { Id = 2, Make = "GMC", Model = "Sierra", Price = 20 });
            system.AddCar(new Car { Id = 3, Make = "Honda", Model = "Accord", Price = 25 });

            system.AddCustomer(new Customer { Id = 1, Name = "Fahad", PhoneNumber = "91234567" });
            system.AddCustomer(new Customer { Id = 2, Name = "Salim", PhoneNumber = "93456789" });
            Console.WriteLine("-------First test--------");
            system.ShowAvailableCars();
            Console.WriteLine("----");
            system.RentCar(1, 3, 15);
            system.ShowAvailableCars();
            system.ShowAllRentals();
            Console.WriteLine("---------Second test---------");
            system.ShowAvailableCars();
            system.RentCar(2, 2, 5);
            system.ShowAvailableCars();
            system.ShowAllRentals();
            system.ReturnCar(2);
            system.ShowAvailableCars();
            Console.WriteLine("--------Result-------");
            system.CalculateTotalRevenue();
        }
    }
}
