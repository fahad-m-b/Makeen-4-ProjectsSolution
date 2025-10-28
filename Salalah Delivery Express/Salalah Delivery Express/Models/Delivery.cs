using _4_Projects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Models
{
    public class Delivery
    {
        public Delivery(int deliveryId, Customer customer)
        {
            DeliveryId = deliveryId;
            this.customer = customer;
            stauts = Status.Pending;
        }

        public int DeliveryId { get; set; }
        public Customer customer { get; set; }
        public Driver driver { get; set; }
        public Status stauts { get; set; }

        public void Update_Status(Status status_new)
        {
            stauts = status_new;
        }
        public bool Assginedriver(Driver checkdriver)
        {
            if (driver != null)
            {
                Console.WriteLine($"Delivery: {DeliveryId} have a driver: {driver.Name}");
                return false;
            }
            driver = checkdriver;
            return true;
        }
        public void Show_Info()
        {
            Console.WriteLine("_______________*_____________");
            Console.WriteLine($"Delivery : {DeliveryId}\nDriver : {driver.Name}|{driver.Car}\nCustomer : {customer.Name}|{customer.Address}\nStatus : {stauts}");
            Console.WriteLine("_______________*_____________");
        }

    }
}
