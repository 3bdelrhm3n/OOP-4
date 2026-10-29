using deliveryCenter;

namespace OOP_4.Models;

internal class StandardShipment : Shipment
{
    public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
    }

    public override decimal EstimatedCost => DeliveryFee + (Weight * 5);

    public override decimal CalculateInsurance()
    {
        return EstimatedCost * 0.05m;
    }

    public override string GetTrackingStatus()
    {
        return $"Standard Shipment with Tracking Code: {TrackingCode} is in transit.";
    }

    public override void PrintShipment()
    {
        {
            Console.WriteLine($"type :{this.GetType().Name}");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        }
    }
}
