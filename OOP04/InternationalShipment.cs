using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class InternationalShipment : Shipment, IInsurable
    {
        string _destinationCountry;
        decimal _customsFee;

        // DestinationCountry cannot be null, empty, or whitespace. 
        public string DestinationCountry
        {
            get { return _destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _destinationCountry = value;
                }
                else
                {
                    throw new ArgumentException("Destination country cannot be null, empty, or whitespace.");
                }
            }
        }

        // CustomsFee must be greater than or equal to 0. 
        public decimal CustomsFee
        {
            get { return _customsFee; }
            set
            {
                if (value >= 0)
                {
                    _customsFee = value;
                }
                else
                {
                    throw new ArgumentException("Customs fee must be a non-negative number.");
                }
            }
        }
        // Override the EstimatedCost property to include the customs fee. 
        // Override EstimatedCost

        //public override decimal EstimatedCost
        //{
        //    get { return DeliveryFee + (decimal)(Weight * 5) + _customsFee; }
        //}

        public override decimal EstimatedCost()
        {
            return DeliveryFee + (decimal)(Weight * 5) + _customsFee;
        }

        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        //public override void PrintShipment()
        //{
        //    Console.WriteLine("International Shipment\n");
        //    base.PrintShipment();
        //    Console.WriteLine($"Destination Country : {DestinationCountry}");
        //    Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
        //}

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Customs Report:");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee} EGP");
        }
        public decimal CalculateInsurance()
        {
            return 0.12m * EstimatedCost();
        }

        public override Shipment CopyShipment()
        {
            return new InternationalShipment(TrackingCode,Description,Weight,DeliveryFee,Destination,DestinationCountry,CustomsFee);
        }
    }

}
