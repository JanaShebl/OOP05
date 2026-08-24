using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class ExpressShipment : Shipment, IInsurable
    {
        decimal _extraFee;
        // ExtraFee must be greater than or equal to 0. 
        public decimal ExtraFee
        {
            get { return _extraFee; }
            set
            {
                if (value >= 0)
                {
                    _extraFee = value;
                }
            }
        }

        // Override the EstimatedCost property to include the extra fee.
        // Override EstimatedCost
        //public override decimal EstimatedCost
        //{
        //    get { return DeliveryFee + (decimal)(Weight * 5) + ExtraFee; }
        //}

        public override decimal EstimatedCost()
        {
            return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
        }

        // Create a constructor that initializes all inherited members and ExtraFee.
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        //public override void PrintShipment()
        //{
        //    Console.WriteLine("Express Shipment\n");
        //    base.PrintShipment();
        //    Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
        //}

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
        }
        public decimal CalculateInsurance()
        {
            return 0.08m * EstimatedCost();
        }
    }

}
