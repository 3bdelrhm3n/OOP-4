using deliveryCenter;

namespace OOP_4.Models;

public  class InternationalShipment : Shipment 
{
    public string DestinationCountry { get; set { if (value != null && value != " ") DestinationCountry = value; } }
    public decimal CustomsFee { get; set { if (value >= 0) CustomsFee = value; } }
    public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination,string destinationCountry,decimal customsFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }
    public override decimal EstimatedCost {get { return DeliveryFee + (Weight * 5) + CustomsFee;} }

    public  virtual void GenerateCustomReport()
    {
        Console.WriteLine($"Priority International Shipment Report: Tracking Code: {TrackingCode},  Destination Country: {DestinationCountry}, Customs Fee: {CustomsFee}");
    }

    public override void PrintShipment()
    {
        Console.WriteLine($"type :{this.GetType().Name}");
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
        Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        
    }

    public override decimal CalculateInsurance()
    {
        return EstimatedCost * 0.12m;
    }

    public override string GetTrackingStatus()
    {
        return $"International Shipment with Tracking Code: {TrackingCode} is in transit.";
    }
}
