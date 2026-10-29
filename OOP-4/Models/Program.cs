using deliveryCenter;
using OOP_4.Interface;
using System.Threading.Channels;

namespace OOP_4.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string centerName = "Alex";
            DeliveryCenter Center = new DeliveryCenter();
            var address = new DeliveryAddress(" cairo ", "Ahmed Abdelazez", 456);
            var standard = new StandardShipment("STD123", "Books", 2.5m, 10,new DeliveryAddress("Alex", "Abou El Fadl", 123));
            var express = new ExpressShipment("EXP456", "Electronics", 5.0m, 20, new DeliveryAddress("Cairo", "Mohamed Hassan", 789), 15);
            var address2 = new DeliveryAddress("Giza", "Ali Mohamed", 321);
            Shipment international = new InternationalShipment("INT789", "Clothes", 3.0m, 15, address2, "USA",25);
            DeliveryAddress address3 = new DeliveryAddress("Cairo", "Ahmed Ali", 456);
            Center.AddShipment(standard);
            Center.AddShipment(express);
            Center.AddShipment(international);
            Center.printAllShipments();
            ITrackable[] trackables = new ITrackable[3] { standard, express, international}; 

            foreach (ITrackable trackable in trackables)
            {
                Console.WriteLine(trackable.GetTrackingStatus());
            }
            Console.WriteLine ("Insurance Costs:");
            Console.WriteLine($"Standard Shipment Insurance: ${standard.CalculateInsurance()}");
            Console.WriteLine($"Express Shipment Insurance: ${express.CalculateInsurance()}");
            Console.WriteLine($"International Shipment Insurance: ${international.CalculateInsurance()}");





        }
    }
}
