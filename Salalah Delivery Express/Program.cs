using _4_Projects.Models;
using System;

namespace Salalah_Delivery_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t ##Project 1## \n\n");

            Customer c1 = new Customer("Fahad", "Salalah");
            Customer c2 = new Customer("Salim", "Yamen");
            Driver d1 = new Driver("Ali", "Salalah");
            Driver d2 = new Driver("Salim", "Muscat");

            Delivery de1 = new Delivery(1, c1);
            Delivery de2 = new Delivery(2, c1);
            Delivery de3 = new Delivery(3, c2);

            de1.Assginedriver(d1);
            de1.Assginedriver(d2);
            de2.Assginedriver(d1);
            de3.Assginedriver(d2);

            de1.Update_Status(_4_Projects.Enums.Status.On_the_Way);
            de3.Update_Status(_4_Projects.Enums.Status.Delivered);

            de1.Show_Info();
            de2.Show_Info();
            de3.Show_Info();

            Console.WriteLine("------------------------------------------\n\n");
        }
    }
}
