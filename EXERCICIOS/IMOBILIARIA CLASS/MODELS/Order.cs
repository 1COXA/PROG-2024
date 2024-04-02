using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.MODELS;

namespace _240401_1.MODELS
{
    public class Order
    {
        public Customer Customer { get; set; }
        public DateTime OrdemDate { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderItem> OrderItem { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Order Retrieve()
        {

        }
    }
}