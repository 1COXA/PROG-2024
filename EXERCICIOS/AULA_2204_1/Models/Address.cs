using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01.Models
{
    public enum AddressType
    {
        Residential,
        Commercial,
        Other
    }

    public class Address
    {
        public int Id { get; set; }       
        public AddressType Type { get; set; } 
        public string Street { get; set; }
        public string District { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string FederalState { get; set; }
        public string Country { get; set; }
        public bool IsDefault { get; set; }

        public Customer Customer {get; set;}
    }
}