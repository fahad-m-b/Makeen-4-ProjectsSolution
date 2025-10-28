using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Dhofar_Car_Rental.Models
{
    public class RentalSystem
    {
        private List<Car> cars = new List<Car>();
        private List<Customer> customers = new List<Customer>();
        private List<RentalRecord> rentals = new List<RentalRecord>();
        private int rentalCounter = 1;

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void ShowAvailableCars()
        {
            Console.WriteLine("\nAvailable Cars:");
            foreach (var car in cars)
            {
                if (car.IsAvilaible)
                    car.ShowDetail();
            }
        }

        public void RentCar(int customerID, int carID, int days)
        {
            Customer customer = null;
            Car car = null;

            foreach (var c in customers)
                if (c.Id == customerID) customer = c;

            foreach (var c in cars)
                if (c.Id == carID) car = c;


            if (customer == null)
            {
                Console.WriteLine("Customer not found!");
                return;
            }

            if (car == null)
            {
                Console.WriteLine("Car not found!");
                return;
            }

            if (!car.IsAvilaible)
            {
                Console.WriteLine("Car is not available!");
                return;
            }

            RentalRecord record = new RentalRecord();
            record.Id = rentalCounter++;
            record.Customer = customer;
            record.Car = car;
            record.DayRented = days;
            record.CalculateTotalCost();

            rentals.Add(record);
            car.MarkAsRented();

            Console.WriteLine("Car rented successfully!");
            Console.WriteLine("Total cost: " + record.TotalCost + " OMR");
        }


        public void ReturnCar(int carID)
        {
            var car = cars.Find(c => c.Id == carID);
            if (car == null)
            {
                Console.WriteLine("Car not found!");
                return;
            }

            car.MarkAsAvailable();
            Console.WriteLine($"{car.Make} {car.Model} has been returned and is now available.");
        }

        public void ShowAllRentals()
        {
            Console.WriteLine("\nAll Rentals:");
            foreach (var rental in rentals)
            {
                rental.ShowRecordDetails();
            }
        }

        public void CalculateTotalRevenue()
        {
            double total = 0;
            foreach (var rental in rentals)
            {
                total += rental.TotalCost;
            }
            Console.WriteLine($"\nTotal Revenue: {total} OMR");
        }

    }
}
