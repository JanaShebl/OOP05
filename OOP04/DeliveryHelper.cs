using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
                Console.WriteLine("Printing Using DeliveryHelper...\n");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }
        }
    }

}
