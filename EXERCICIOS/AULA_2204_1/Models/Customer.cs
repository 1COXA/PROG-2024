namespace _240401_01.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; }

        public Customer()
        {
            
        }

        public Customer(int id)
        {
            CustomerId = id;
        }

        public bool Validate()
        {
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();            
        }

        public void Save(Customer customer)
        {

        }
    }
}