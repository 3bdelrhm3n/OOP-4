

using deliveryCenter;

namespace OOP_4.Models
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost => throw new NotImplementedException();

        public override decimal CalculateInsurance()
        {
            throw new NotImplementedException();
        }

        public override string GetTrackingStatus()
        {
            throw new NotImplementedException();
        }

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
    }
}
