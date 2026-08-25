using OOP04;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP005
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} KG | {shipment.Status}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.Status == "Delivered";
        }
    }
}
