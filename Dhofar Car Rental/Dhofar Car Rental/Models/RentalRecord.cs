using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Dhofar_Car_Rental.Models
{
    public class RentalRecord
    {
        public int TotalCost { get; set; }
        public int Id { get; set; }
        public int DayRented { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }

        public void CalculateTotalCost()
        {

            TotalCost = Car.Price * DayRented;

            Console.WriteLine($"Total price of the car:{Car.Model} price of renting for:{DayRented} is:{TotalCost}OMR");
        }
        public void ShowRecordDetails()
        {
            Console.WriteLine($"Rental ID: {Id}, Customer: {Customer.Name}, Car: {Car.Make} {Car.Model}, " +
                              $"Days: {DayRented}, Total: {TotalCost} OMR");
        }
    }
}
