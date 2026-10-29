
using deliveryCenter;
using OOP_4.Interface;

namespace OOP_4.Models;
public abstract class Shipment : ITrackable, IInsurable
{
    string trackingCode;
    string description;
    decimal weight;
    decimal deliveryFee;
    DeliveryAddress destination;

    public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
    {
        TrackingCode = trackingCode;
        Description = description;
        Weight   = weight;
        DeliveryFee  = deliveryFee;
        Destination = destination;
    }
    public string TrackingCode
    {
        get { return trackingCode; }
       private set
        {
            if (!string.IsNullOrWhiteSpace (value))
            {
                trackingCode = value;
            }
        }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                description = value;
            }
        }
    }

    public decimal Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
            {
                weight = value;
            }
        }
    }

    public decimal DeliveryFee
    {
        get { return deliveryFee; }
       private set
        {
            if (value > 0)
            {
                deliveryFee = value;
            }
        }
    }

    public DeliveryAddress Destination
    {
        get { return destination; }
        set
        {
            destination = value;
        }
    }

    public abstract decimal EstimatedCost { get; }
 
    
    public void UpdateDeliveryFee(decimal newFee)
    {
         DeliveryFee = newFee;
    }
    public Shipment (string trackingCode): this(trackingCode, "Unknown", 1, 50 , new DeliveryAddress ("unknown","unknown",0)) { }
    public abstract void PrintShipment();

    public abstract decimal CalculateInsurance();
    public abstract string GetTrackingStatus();
   
}
