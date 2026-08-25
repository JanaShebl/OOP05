using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments = new Shipment[20];

        // • Add an integer indexer this[int index] to get or set a shipment by position
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                return null;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        //  Add a string indexer this[string trackingCode] that returns the first shipment with the matching tracking code.
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return null;
            }
        }

        //  Add bool AddShipment(Shipment shipment), which adds the shipment to the first empty position and returns true.
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        string _centerName;

        public string CenterName { get; set; }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        // print all shipments in the delivery center.
        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                }
            }
        }

        Driver _driver;
        public Driver Driver { get; set; }
        public DeliveryCenter(string centerName, Driver driver)
        {
            CenterName = centerName;
            Driver = driver;
        }

        // it loops through all shipments and prints their tracking status using the ITrackable interface.

        public void PrintTrackingStatuses()
        {
            foreach (ITrackable i in shipments)
            {
                Console.WriteLine(i.GetTrackingStatus);
            }
        }


    }

}
