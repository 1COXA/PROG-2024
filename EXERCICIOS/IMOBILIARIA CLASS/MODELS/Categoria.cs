using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01.MODELS
{
    
    public class Customer
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string WorkAddress { get; set; }

      public Customer()
      {

      }

      public Customer(int id)
      {
        CustomerId = id;
      }
    }
}