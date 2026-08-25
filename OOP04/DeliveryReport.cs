using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }
            else
            {
                Console.WriteLine("Invalid\n");
            }
        }
        public void PrintInsurance(IInsurable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine(shipment.CalculateInsurance());
            }
            else
            {
                Console.WriteLine("Invalid\n");
            }
        }
    }
}
