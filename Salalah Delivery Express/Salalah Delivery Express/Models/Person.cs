using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Models
{
    public class Customer
    {
        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class Driver
    {
        public Driver(string name, string car)
        {
            Name = name;
            Car = car;
        }

        public string Name { get; set; }
        public string Car { get; set; }
    }
}
