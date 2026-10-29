using deliveryCenter;
using System.Security.AccessControl;

namespace OOP_4.Models;

internal class ExpressShipment : Shipment
{
    public decimal ExtraFee { get; set { if (value >= 0) ExtraFee = value; } }
    
    public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination,decimal extraFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        ExtraFee = extraFee;
    }
    public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + ExtraFee; 
    
    public override void PrintShipment()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
        Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
    }

    public override decimal CalculateInsurance()
    {
        return EstimatedCost * 0.08m;
    }

    public override string GetTrackingStatus()
    {
        return $"Express Shipment with Tracking Code: {TrackingCode} is in transit.";
    }
}

