using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class Driver
    {
        int _driverId;
        string _fullName;
        string _phoneNumber;

        public int DriverId
        {
            get { return _driverId; }
            set
            {
                if (value > 0)
                {
                    _driverId = value;
                }
                else
                {
                    throw new ArgumentException("Driver ID must be a positive integer.");
                }
            }
        }
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !double.TryParse(value, out _))
                {
                    _fullName = value;
                }
                else
                {
                    throw new ArgumentException("Full name must be a non-empty string and not a valid number.");
                }
            }

        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Phone number must be a non-empty field.");
                }
            }
        }

        public Driver(string fullName, string phoneNumber, int driverId)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            DriverId = driverId;
        }

    }

}
