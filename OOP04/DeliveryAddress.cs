using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class DeliveryAddress
    {

        private string City;
        private string Street;
        private int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            string fullAddress = $"Building number : {BuildingNumber}, Street : {Street}, City : {City}";
            return fullAddress;
        }

        public DeliveryAddress(DeliveryAddress address)
        {
            City = address.City;
            Street = address.Street;
            BuildingNumber = address.BuildingNumber;
        }
        public string GetCity { get; set; }
    }
}
