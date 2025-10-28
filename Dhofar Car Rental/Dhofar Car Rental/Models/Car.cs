using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Dhofar_Car_Rental.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public bool IsAvilaible { get; set; } = true;

        public void MarkAsRented() { IsAvilaible = false; }
        public void MarkAsAvailable() { IsAvilaible = true; }
        public void ShowDetail()
        {
            Console.WriteLine($"ID:{Id}\nMake:{Make}\nModel:{Model}\nPrice per Day:{Price}\n Status:{(IsAvilaible ? "Avilaible" : "Rented")}");
        }
    }
}
