using System.Security.AccessControl;

namespace OOP_4.Models
{
    internal class Driver
    {

        public int DriverId { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public Driver(int driverId, string name, int phoneNumber)
        {
            DriverId = driverId;
            Name = string.IsNullOrWhiteSpace(name) ? "Unknown" :name;
            PhoneNumber = string.IsNullOrWhiteSpace (phoneNumber.ToString ()) ? 0 : phoneNumber;
        }
       
    }
}
