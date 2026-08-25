using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class StandardShipment : Shipment, IInsurable
    {
        // Create a constructor that initializes all inherited members using constructor chaining. 
        // constructor chaining is done by calling the base class
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        //public override void PrintShipment()
        //{
        //    Console.WriteLine("Standard Shipment\n");
        //    base.PrintShipment();
        //}

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        public override decimal EstimatedCost()
        {
            return DeliveryFee;
        }

        /*Every shipment type implements this interface. Example outputs:
Shipment SH001 is Ready.
Shipment SH002 is Out for Delivery.
Shipment SH003 has been Delivered.
*/
        //public string GetTrackingStatus()
        //{

        //}
        public decimal CalculateInsurance()
        {
            return 0.05m * EstimatedCost();
        }

        public override Shipment CopyShipment() {
            return new StandardShipment(TrackingCode, Description, Weight, DeliveryFee,Destination);
        }
    }

}
