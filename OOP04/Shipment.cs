using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal abstract class Shipment : ITrackable
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;
        //private string _status;

        public string Status { get; set; }


        public string TrackingCode
        {
            get { return trackingCode; }
            private set // read only
            {
                if (!string.IsNullOrWhiteSpace(value) && !double.TryParse(value, out double trackingNumber) && value.Length >= 5)
                {
                    trackingCode = value;
                }
                else
                {
                    throw new ArgumentException("Tracking code must be a non-empty string , a valid number and at least 5 characters long.");
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !double.TryParse(value, out _))
                {
                    description = value;
                }
                else
                {
                    throw new ArgumentException("Description must be a non-empty string and not a valid number.");
                }
            }

        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Weight must be a positive number.");
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
                else
                {
                    throw new ArgumentException("Delivery fee must be a positive number.");
                }
            }
        }

        public DeliveryAddress Destination
        {
            get { return destination; }
            private set
            {
                destination = value;
            }
        }

        // كنت عملاها من الاسايمنت اللي فات virtual عشان اقدر اعمل override في ال InternationalShipment
        //public virtual decimal EstimatedCost
        //{
        //    get { return DeliveryFee + (decimal)(Weight * 5); }
        //}

        // The first constructor receives only trackingCode.
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        // • The second constructor receives trackingCode, description, weight, deliveryFee, and destination.
        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = new DeliveryAddress(destination);
        }

        //  UpdateDeliveryFee(decimal newFee): updates the fee only when newFee is greater than 0. 
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
            else
            {
                throw new ArgumentException("New delivery fee must be a positive number.");
            }

        }

        // • PrintShipment(): prints all shipment information, including the estimated cost. 
        // كنت عملتها virtual عشان اقدر اعمل override من الاسايمنت اللي فات
        //public virtual void PrintShipment()
        //{
        //    Console.WriteLine($"Tracking Code: {TrackingCode}");
        //    Console.WriteLine($"Description: {Description}");
        //    Console.WriteLine($"Weight: {Weight} KG");
        //    Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
        //    Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        //}

        public void UpdateWeight(double newWeight)
        {
            Weight = newWeight;
        }
        public void UpdateWeight(double newWeight, double extraWeight)
        {
            Weight = newWeight + extraWeight;
        }

        public abstract decimal EstimatedCost();

        public abstract void PrintShipment();

        public string GetTrackingStatus()
        {
            return $"Tracking Code: {TrackingCode}, Status: {Status}";
        }

        public abstract Shipment CopyShipment();
        public Shipment ShallowCopy()
        {
            return (Shipment) this.MemberwiseClone();
        }

        public abstract Shipment DeepCopy();

    }


}
