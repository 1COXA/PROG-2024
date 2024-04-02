using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_1.MODELS
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float CurrentPrice { get; set; }
        
        public bool Validate()
        {
            return true;
        }
        public Product product Retrieve()
        {
            return new Product();
        }
        public void save(Product product)
        {
            
        }

    }
}