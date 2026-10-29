using OOP_4.Interface;

namespace OOP_4.Models
{
    public static class DeliveryReport7
    {
        public static void PrintShipment(ITrackable shipment)
        {
             Console.WriteLine($"Shipment Tracking Status: {shipment.GetTrackingStatus()}");
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Shipment Insurance Cost: ${shipment.CalculateInsurance()}");
        }
    }
}
