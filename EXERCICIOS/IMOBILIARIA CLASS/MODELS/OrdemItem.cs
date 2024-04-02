using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_1.MODELS
{
    public class OrdemItem
    {
        
        public Product Product {get; set;};
        public double Quantity { get; set; }
        public double PurchasePrice { get; set; }
        public bool Validate()
        {
            return true;
        }
        public OrdemItem Retrieve()
        {
            return new OrdemItem();
        }
        public void Save(OrdemItem ordertime)
        {
            
        }
    }
}